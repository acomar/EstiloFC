using System.Data.Entity;

namespace Repository.Contexts
{
    public interface IDbContextFactory
    {
        DbContext GetDbContext();
    }
}
