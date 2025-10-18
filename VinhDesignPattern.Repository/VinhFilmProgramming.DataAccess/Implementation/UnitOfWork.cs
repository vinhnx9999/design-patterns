using VinhFilmProgramming.DataAccess.Context;
using VinhFilmProgramming.Domain.Repositories;

namespace VinhFilmProgramming.DataAccess.Implementation;

public class UnitOfWork(VinhFilmDbContext dbContext) : IUnitOfWork
{
    private readonly VinhFilmDbContext _dbContext = dbContext;
    private bool _disposed = false;

    public IActorRepository Actor { get; set; } = new ActorRepository(dbContext);
    public IFilmRepository Film { get; set; } = new FilmRepository(dbContext);
    public ICategoryRepository Category { get; set; } = new CategoryRepository(dbContext);
    public IBiographyRepository Biography { get; set; } = new BiographyRepository(dbContext);

    public int Save()
    {
        return _dbContext.SaveChanges();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
        _disposed = true;
    }

    public void Dispose()
    {
        _dbContext.Dispose();
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}