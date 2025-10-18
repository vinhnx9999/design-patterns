namespace VinhFilmProgramming.Domain.Entities;

public class Film : StandardEntity
{    
    public string Description { get; set; } = string.Empty;
    public virtual Actor? Actor { get; set; }
    public virtual List<Category>? Category { get; set; }
}
