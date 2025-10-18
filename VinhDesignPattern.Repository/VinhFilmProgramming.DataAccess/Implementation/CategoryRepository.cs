using VinhFilmProgramming.DataAccess.Context;
using VinhFilmProgramming.Domain.Entities;
using VinhFilmProgramming.Domain.Repositories;

namespace VinhFilmProgramming.DataAccess.Implementation;

public class CategoryRepository(VinhFilmDbContext dbContext) : GenericRepository<Category>(dbContext), ICategoryRepository { }
