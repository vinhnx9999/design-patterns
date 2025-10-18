using VinhFilmProgramming.DataAccess.Context;
using VinhFilmProgramming.Domain.Entities;
using VinhFilmProgramming.Domain.Repositories;

namespace VinhFilmProgramming.DataAccess.Implementation;
public class ActorRepository(VinhFilmDbContext dbContext) : GenericRepository<Actor>(dbContext), IActorRepository {}
