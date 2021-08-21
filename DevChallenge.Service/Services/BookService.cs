using DevChallenge.Data.Entities;
using DevChallenge.Data.Repositories.Interfaces;
using DevChallenge.Service.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevChallenge.Service.Services
{
    public class BookService : IBookService
    {
        readonly IBookRepository<Book> _bookRepository;

        public BookService(IBookRepository<Book> bookRepository) => _bookRepository = bookRepository;

        public async Task<IEnumerable<Book>> GetAllBooks() => await _bookRepository.GetAll().ToListAsync();

        public async Task<Book> GetBookById(int bookId) => await _bookRepository.GetById(bookId);

        /*
         * Caso queira salvar as alterações na entidade, só chamar "await _bookRepository.SaveAsync();"
         */
        public async Task InsertBook(Book book) => await _bookRepository.Insert(book);

        public async Task RemoveBook(int bookId) => await _bookRepository.Remove(bookId);

        public void UpdateBook(Book book) => _bookRepository.Update(book);
    }
}