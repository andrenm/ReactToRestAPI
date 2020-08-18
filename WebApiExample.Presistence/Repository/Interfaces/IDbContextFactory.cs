using WebApiExample.Persistence.Models;

namespace WebApiExample.Persistence.Repositories.Interfaces
{
    public interface IDbContextFactory
    {
        WebApiExampleDbContext webApiExampleDbContext { get; }
    }
}
