namespace DevChallenge.Data.Repositories.Interfaces
{
    public interface IBookRepository<TEntity> : IRepository<TEntity> where TEntity : class { }
}