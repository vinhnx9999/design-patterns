
using Microsoft.EntityFrameworkCore;
using VinhFilmProgramming.DataAccess.Context;
using VinhFilmProgramming.DataAccess.Implementation;
using VinhFilmProgramming.Domain.Repositories;

namespace VinhFilmProgramming.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        // Add Entity Framework Core DbContext & SQLite Service to DI
        builder.Services.AddDbContext<VinhFilmDbContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("FilmDatabase")));

        // Add services to DI
        builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
