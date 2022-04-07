using System.Threading.Tasks;

namespace TesteAPI.Infra.Transaction
{
    public class UnitOfWork : IUnitOfWork //<ApiDbContext>
    {
        private readonly ApiDbContext _context;

        public UnitOfWork(ApiDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Rollback()
        {
        }
    }
}
