using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DevChallenge.Data.Context;
using DevChallenge.Data.Repositories.Interfaces;

namespace DevChallenge.Data.Repositories
{
    public class Repository <T> : IRepository<T> where T : class
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

        public virtual T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(T entity)
        {
            _dbSet.Add(entity);            
        }

        public virtual void Update(T entity)
        {
           _dbSet.Update(entity);                   
        }

        public virtual void Remove(object id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }
    }
}