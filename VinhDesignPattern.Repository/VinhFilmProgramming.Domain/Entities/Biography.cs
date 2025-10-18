namespace VinhFilmProgramming.Domain.Entities;

public class Biography: BaseEntity
{
    public string Description { get; set; } = string.Empty;
    public virtual Actor? Actor { get; set; }
}