namespace VinhFilmProgramming.Domain.Repositories;

public interface IUnitOfWork : IDisposable
{
    IActorRepository Actor { get; }
    IFilmRepository Film { get; }
    ICategoryRepository Category { get; }
    IBiographyRepository Biography { get; }

    int Save();
}
