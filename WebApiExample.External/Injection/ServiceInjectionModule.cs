using WebApiExample.External.Services;
using WebApiExample.External.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.External.Injection
{
    public static class ServiceInjectionModule
    {
        /// <summary>
        /// Dependency inject services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection InjectServices(this IServiceCollection services)
        {
            services.AddTransient<IEmployeesService, EmployeesService>();
            return services;
        }
    }
}
