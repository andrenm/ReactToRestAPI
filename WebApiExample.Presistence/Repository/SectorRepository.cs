using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Persistence.Models;
using WebApiExample.Persistence.Repositories.Interfaces;

namespace WebApiExample.Persistence.Repositories
{
    public class SectorRepository : Repository<TbSectors>, ISectorsRepository
    {
        public SectorRepository(IDbContextFactory dbContextFactory,  ILogger logger) :
                                                               base(dbContextFactory, logger)
        {
        }

        /// <summary>
        /// GetAllSectorsAsync
        /// </summary>
        /// <returns>Sectors</returns>
        public async Task<List<TbSectors>> GetAllSectorsAsync()
        {
            var sectors = await _webApiExampleDbContext.TbSectors.OrderByDescending(x => x.NameSector).ToListAsync();
            return sectors;
        }
    }
}
