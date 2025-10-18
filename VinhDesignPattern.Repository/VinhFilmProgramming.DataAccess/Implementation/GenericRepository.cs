using VinhFilmProgramming.DataAccess.Context;
using VinhFilmProgramming.Domain.Repositories;

namespace VinhFilmProgramming.DataAccess.Implementation;

public class GenericRepository<T>(VinhFilmDbContext dbContext) : IGenericRepository<T> where T : class
{
    private readonly VinhFilmDbContext _dbContext = dbContext;

    public void Add(T entity) => _dbContext.Set<T>().Add(entity);

    public void AddRange(IEnumerable<T> entities) => _dbContext.Set<T>().AddRange(entities);

    public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate) 
        => _dbContext.Set<T>().Where(predicate);

    public IEnumerable<T> GetAll() => [.._dbContext.Set<T>()];

    public T GetById(int id)
    {
#pragma warning disable CS8603 // Possible null reference return.
        return _dbContext.Set<T>().Find(id);
#pragma warning restore CS8603 // Possible null reference return.
    }

    public void Remove(T entity) => _dbContext.Set<T>().Remove(entity);

    public void RemoveRange(IEnumerable<T> entities) => _dbContext.Set<T>().RemoveRange(entities);
}
