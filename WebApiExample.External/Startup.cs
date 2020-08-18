using Serilog;
using System.IO;
using WebApiExample.External.Injection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApiExample.Persistence;
using EasyTimeSheet.Api.Persistence.Injection;

namespace WebApiExample.External
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private readonly string MyAllowSpecificOrigins = "http://localhost:3000";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins(MyAllowSpecificOrigins)
                      .AllowAnyHeader()
                      .AllowAnyMethod();
                });
            });

            //Inject logger
            services.AddSingleton(Log.Logger);

            services.AddControllers();
            services.InjectPersistence();
            services.InjectServices();
            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
            services.Configure<DbContextSettings>(Configuration);
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "WebApiExample.AppWeb/build";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(MyAllowSpecificOrigins);
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseMvc();
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = Path.Join(env.ContentRootPath, "WebApiExample.AppWeb");

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
