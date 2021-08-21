using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DevChallenge.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> GetById(object id);
        Task Insert(T entity);
        void Update(T entity);
        Task Remove(object id);
        Task<int> SaveAsync(CancellationToken cancellationToken = default);
    }
}