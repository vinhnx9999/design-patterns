namespace VinhFilmProgramming.Domain.Entities;

public class Category: StandardEntity
{        
    public virtual List<Film>? Films { get; set; }
}
