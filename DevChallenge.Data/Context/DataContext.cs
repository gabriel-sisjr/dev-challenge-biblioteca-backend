using Microsoft.EntityFrameworkCore;
using DevChallenge.Data.Entities;      

namespace DevChallenge.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
            {
            }
        public DbSet<Book> Books { get; set; }
    }
}