using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiExample.Persistence.Models;

namespace WebApiExample.Persistence.Repositories.Interfaces
{
    public interface ISectorsRepository : IRepository<TbSectors>
    {
        Task<List<TbSectors>> GetAllSectorsAsync();
    }
}
