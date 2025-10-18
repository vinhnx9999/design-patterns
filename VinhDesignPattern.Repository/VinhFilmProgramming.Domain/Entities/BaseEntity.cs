using System.ComponentModel.DataAnnotations;

namespace VinhFilmProgramming.Domain.Entities;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}

public class StandardEntity : BaseEntity
{
    public string Name { get; set; } = string.Empty;
}