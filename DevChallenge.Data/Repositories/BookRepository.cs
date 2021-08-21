using System;
using System.Linq;
using DevChallenge.Data.Repositories.Interfaces;
using DevChallenge.Data.Entities;

namespace DevChallenge.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IRepository<Book> _repository;

        public BookRepository(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public IQueryable<Book> GetAll()
        {
            return _repository.GetAll();
        }

        public Book GetById(int bookId)
        {
            return _repository.GetById(bookId);
        }

        public void Insert(Book book)
        {
            _repository.Insert(book);
        }

        public void Update(Book book)
        {
            _repository.Update(book);
        }

        public void Remove(int bookId)
        {
            _repository.Remove(bookId);
        }
    }
}