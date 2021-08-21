using DevChallenge.Data.Context;
using DevChallenge.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DevChallenge.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DataContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(DataContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        public async Task<T> GetById(object id) => await _dbSet.FindAsync(id);

        public async Task Insert(T entity) => await _dbSet.AddAsync(entity);

        public void Update(T entity) => _dbSet.Update(entity);

        public async Task Remove(object id) => _dbSet.Remove(await _dbSet.FindAsync(id));

        public async Task<int> SaveAsync(CancellationToken cancellationToken = default) => await _context.SaveChangesAsync(cancellationToken);
    }
}