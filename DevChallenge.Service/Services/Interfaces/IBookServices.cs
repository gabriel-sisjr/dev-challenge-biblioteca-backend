using System;
using System.Collections.Generic;
using DevChallenge.Data.Entities;


namespace DevChallenge.Service.Services.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
        void InsertBook(Book book);
        void UpdateBook(Book book);
        void RemoveBook(int bookId);
    }
}