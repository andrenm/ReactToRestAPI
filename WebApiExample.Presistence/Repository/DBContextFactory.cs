using System;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using WebApiExample.Persistence.Models;
using WebApiExample.Persistence.Repositories.Interfaces;

namespace WebApiExample.Persistence.Repositories
{
    public class DbContextFactory : IDbContextFactory, IDisposable
    {
        public WebApiExampleDbContext webApiExampleDbContext { get; private set; }
       
        /// <summary>
        /// Create Db context with connection string
        /// </summary>
        /// <param name="settings"></param>
        public DbContextFactory(IOptions<DbContextSettings> settings)
        {
            var options= new DbContextOptionsBuilder<WebApiExampleDbContext>()
                .UseSqlServer(settings.Value.WebApiExampleConnectionString).Options;

            webApiExampleDbContext = new WebApiExampleDbContext(options);
        }

        /// <summary>
        /// Call Dispose to release DbContext
        /// </summary>
        ~DbContextFactory()
        {
            Dispose();
        }

        /// <summary>
        /// Release DB context
        /// </summary>
        public void Dispose()
        {
            webApiExampleDbContext?.Dispose();
        }
    }
}
