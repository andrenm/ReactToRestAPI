using System.Collections.Generic;
using System.Threading.Tasks;
using Serilog;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.External.Services.Interfaces;
using WebApiExample.Persistence.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiExample.External.Controllers
{
  [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
          private readonly IEmployeesService _service;
         private readonly ILogger _logger;

         public EmployeesController(IEmployeesService service, ILogger logger)
         {
             _service = service;
             _logger = logger;
         }

         // GET: api/<controller>
         [HttpGet]
         [Route("get")]
         public async Task<ActionResult<List<TbEmployees>>> Get()
         {
             var employees = await _service.GetAllEmployeesAsync();
             return Ok(employees);
         }

         // POST api/<controller>
         [HttpPost]
       //  [Route("post/{IdUser:int}")]
         public  ActionResult<bool> Post([FromBody]int idUser)
         {
             return  Ok(true);
           //  await _service.InsertOrUpdateUserAsync(user);
         }

    }
}
