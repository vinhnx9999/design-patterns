namespace VinhFilmProgramming.Domain.Entities;

public class Actor: BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public Biography? Biography { get; set; }
    public List<Film>? Films { get; set; }
}
