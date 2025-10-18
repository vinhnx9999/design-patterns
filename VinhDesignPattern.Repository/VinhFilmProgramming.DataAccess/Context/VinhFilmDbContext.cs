using Microsoft.EntityFrameworkCore;
using VinhFilmProgramming.Domain.Entities;

namespace VinhFilmProgramming.DataAccess.Context;

public class VinhFilmDbContext(DbContextOptions<VinhFilmDbContext> options) : DbContext(options)
{
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Film> Films { get; set; }
    public DbSet<Biography> Biographies { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {        
    }
}
