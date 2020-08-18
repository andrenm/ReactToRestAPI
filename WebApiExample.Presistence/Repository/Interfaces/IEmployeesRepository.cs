using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiExample.Persistence.Models;

namespace WebApiExample.Persistence.Repositories.Interfaces
{
    public interface IEmployeesRepository : IRepository<TbEmployees>
    {
        Task<List<TbEmployees>> GetAllEmployeesAsync();
        Task InsertOrUpdateEmployeesAsync(TbEmployees employees);
    }
}
