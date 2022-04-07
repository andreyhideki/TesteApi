using System.Threading.Tasks;

namespace TesteAPI.Infra.Transaction
{
    public interface IUnitOfWork //<T> where T : IDataContext
    {
        void Commit();
        Task CommitAsync();
        void Rollback();
    }
}
