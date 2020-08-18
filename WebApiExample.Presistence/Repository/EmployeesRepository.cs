using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Persistence.Models;
using WebApiExample.Persistence.Repositories.Interfaces;

namespace WebApiExample.Persistence.Repositories
{
    public class EmployeesRepository : Repository<TbEmployees>, IEmployeesRepository
    {
        public EmployeesRepository(IDbContextFactory dbContextFactory, ILogger logger) :
                                                               base(dbContextFactory, logger)
        {
        }

        /// <summary>
        /// GetAllEmployeesAsync
        /// </summary>
        /// <returns>Employees</returns>
        public async Task<List<TbEmployees>> GetAllEmployeesAsync()
        {

            try
            {
                var employees = await (from emp in _webApiExampleDbContext.TbEmployees
                                       join sec in _webApiExampleDbContext.TbSectors on emp.IdSector equals sec.IdSector into joined
                                       from j in joined
                                       select new TbEmployees
                                       {
                                           IdEmployee = emp.IdEmployee,
                                           NameFull = emp.NameFull,
                                           ContactNumber = emp.ContactNumber,
                                           Email = emp.Email,
                                           Thumbnail = emp.Thumbnail,
                                           NameSector = j.NameSector
                                       })
           .OrderByDescending(x => x.NameFull)
           .ToListAsync();

                return employees;
            }
            catch(Exception ex)
            {
                throw ex;
            }
          
        }

        /// <summary>
        /// InsertOrUpdateEmployeesAsync
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        public async Task InsertOrUpdateEmployeesAsync(TbEmployees employees)
        {
            var entity = await GetEntity(employees.IdEmployee);
            if (entity != null)
            {
                entity.NameFull = employees.NameFull;
                entity.ContactNumber = employees.ContactNumber;
                entity.Email = employees.Email;
                entity.IdSector = employees.IdSector;
                await UpdateEntity(entity);
            }
            else
            {
                await AddEntity(employees);
            }
        }
    }
}
