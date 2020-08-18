using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiExample.Persistence.Models;

namespace WebApiExample.External.Services.Interfaces
{
    public interface IEmployeesService
    {
      Task<List<TbEmployees>> GetAllEmployeesAsync();
        Task InsertOrUpdateEmployeesAsync(TbEmployees employees);
    }
}
