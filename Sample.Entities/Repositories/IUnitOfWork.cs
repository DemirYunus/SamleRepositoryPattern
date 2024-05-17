using System.Transactions;

namespace Sample.Entities.Repositories
{
    public interface IUnitOfWork
    {
        //Transaction ile işlemi geri almak işine yarıyor
        Task<int> SaveShangesAsync(CancellationToken cancellationToken = default);
    }
}
