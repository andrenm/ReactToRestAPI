using Microsoft.Extensions.DependencyInjection;
using WebApiExample.Persistence.Repositories;
using WebApiExample.Persistence.Repositories.Interfaces;

namespace EasyTimeSheet.Api.Persistence.Injection
{
    public static class RepositoryInjectionModule
    {
        /// <summary>
        ///  Dependency inject DbContextFactory and CustomerRepository
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection InjectPersistence(this IServiceCollection services)
        {
            services.AddScoped<IDbContextFactory, DbContextFactory>();
            services.AddTransient<IEmployeesRepository, EmployeesRepository>();
            return services;
        }
    }
}
