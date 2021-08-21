using DevChallenge.Data.Context;
using DevChallenge.Data.Entities;
using DevChallenge.Data.Repositories.Interfaces;

namespace DevChallenge.Data.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository<Book>
    {
        private readonly IRepository<Book> _repository;

        public BookRepository(DataContext context, IRepository<Book> repository) : base(context) => _repository = repository;
    }
}