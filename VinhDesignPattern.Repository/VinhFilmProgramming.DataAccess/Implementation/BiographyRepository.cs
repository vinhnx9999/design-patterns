using VinhFilmProgramming.DataAccess.Context;
using VinhFilmProgramming.Domain.Entities;
using VinhFilmProgramming.Domain.Repositories;

namespace VinhFilmProgramming.DataAccess.Implementation;

public class BiographyRepository(VinhFilmDbContext dbContext) : GenericRepository<Biography>(dbContext), IBiographyRepository { }
