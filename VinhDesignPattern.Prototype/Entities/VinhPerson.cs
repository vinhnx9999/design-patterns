namespace VinhDesignPattern.Prototype.Entities;

public class VinhPerson
{
    public int Age;
    public DateTime BirthDate;
    public string Name = string.Empty;
    public IdInfo IdInfo = new();

    public VinhPerson ShallowCopy()
    {
        return (VinhPerson)MemberwiseClone();
    }

    public VinhPerson DeepCopy()
    {
        VinhPerson clone = (VinhPerson)MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = Name;
        return clone;
    }
}
