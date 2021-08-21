using System;
using System.Collections.Generic;
using DevChallenge.Data.Repositories.Interfaces;
using DevChallenge.Service.Services.Interfaces;
using DevChallenge.Data.Entities;

namespace DevChallenge.Service.Services
{
    public class BookService : IBookService
    {
        readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAll();
        }

        public Book GetBookById(int bookId)
        {
            return _bookRepository.GetById(bookId);
        }

        public void InsertBook(Book book)
        {
            _bookRepository.Insert(book);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
        }

        public void RemoveBook(int bookId)
        {
            _bookRepository.Remove(bookId);
        }
    }
}