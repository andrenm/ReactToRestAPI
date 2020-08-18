using System;
using System.Threading.Tasks;
using WebApiExample.Persistence.Models;
using WebApiExample.Persistence.Repositories.Interfaces;
using Serilog;

namespace WebApiExample.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class
    {
        private readonly IDbContextFactory _dbContextFactory;
        protected WebApiExampleDbContext _webApiExampleDbContext => _dbContextFactory?.webApiExampleDbContext;
        protected ILogger Logger;

        public Repository(IDbContextFactory dbContextFactory, ILogger logger)

        {
            _dbContextFactory = dbContextFactory;
            Logger = logger;
        }


        /// <summary>
        /// Get Entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TEntity> GetEntity(object id)
        {
            var entity = await _webApiExampleDbContext.FindAsync<TEntity>(id);
            return entity;
        }

        /// <summary>
        /// Add Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TEntity> AddEntity(TEntity entity)
        {
            try
            {
                var result = await _webApiExampleDbContext.AddAsync<TEntity>(entity);
                await _webApiExampleDbContext.SaveChangesAsync();
                return result.Entity;
            }

            catch (Exception ex)
            {
                Logger.Error(ex, "Unhandled Exception");
                throw;
            }
        }

        /// <summary>
        /// Update Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TEntity> UpdateEntity(TEntity entity)
        {
            _webApiExampleDbContext.Update<TEntity>(entity);
            await _webApiExampleDbContext.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteEntity(object id)
        {
            var entity = await _webApiExampleDbContext.FindAsync<TEntity>(id);
            if (entity != null)
            {
                _webApiExampleDbContext.Remove<TEntity>(entity);
                await _webApiExampleDbContext.SaveChangesAsync();
            }
            return true;
        }
    }
}
