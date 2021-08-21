using System;
using System.Linq;
using DevChallenge.Data.Entities;

namespace DevChallenge.Data.Repositories.Interfaces
{
    public interface IBookRepository
    {
        IQueryable<Book> GetAll();
        Book GetById(int bookId);
        void Insert(Book book);
        void Update(Book book);
        void Remove(int bookId);
    }
}