using System;
using System.Data.Entity;

namespace Repository.Contexts
{
    public class DbContextFactory : IDbContextFactory
    {
        private readonly DbContext _context;

        public DbContextFactory()
        {
            _context = new AppContext();
        }

        DbContext IDbContextFactory.GetDbContext()
        {
            return _context;
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                GC.SuppressFinalize(this);
            }
        }
    }
}
