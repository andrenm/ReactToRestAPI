﻿using System.Threading.Tasks;

namespace WebApiExample.Persistence.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetEntity(object id);
        Task<T> AddEntity(T entity);
        Task<T> UpdateEntity(T entity);
        Task<bool> DeleteEntity(object id);
    }
}
