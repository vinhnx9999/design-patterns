using VinhFilmProgramming.DataAccess.Context;
using VinhFilmProgramming.Domain.Entities;
using VinhFilmProgramming.Domain.Repositories;

namespace VinhFilmProgramming.DataAccess.Implementation;

public class FilmRepository(VinhFilmDbContext dbContext) : GenericRepository<Film>(dbContext), IFilmRepository { }
