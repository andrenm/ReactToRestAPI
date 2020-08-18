using WebApiExample.External.Services.Interfaces;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Persistence.Repositories.Interfaces;
using WebApiExample.Persistence.Models;

namespace WebApiExample.External.Services
{
    public class EmployeesService : IEmployeesService
    {
      private readonly IEmployeesRepository _repository;
        private readonly ILogger _logger;
        public EmployeesService(IEmployeesRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }
        /// <summary>
        /// GetLastAccessedUsersAsync
        /// </summary>
        /// <returns>Users</returns>

        public async Task<List<TbEmployees>> GetAllEmployeesAsync()
        {
            var response = await _repository.GetAllEmployeesAsync();
            return response;
        }

        /// <summary>
        /// UpdateLastAccessedUsersAsync
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task InsertOrUpdateEmployeesAsync(TbEmployees employees)
        {
          //  employees.AlterDate = DateTime.UtcNow;
            await _repository.InsertOrUpdateEmployeesAsync(employees);
        }
    }
}
