using System;
using System.Linq;

namespace DevChallenge.Data.Repositories.Interfaces
{
    public interface IRepository <T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Remove(object id);
    }    
}