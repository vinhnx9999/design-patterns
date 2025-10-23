using VinhDesignPattern.Prototype.Entities;

namespace VinhDesignPattern.Prototype;

public class Program
{
    [Obsolete]
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Prototype Design Pattern!");
        VinhPerson p1 = new()
        {
            Age = 42,
            BirthDate = DateTime.UtcNow.AddYears(-42),
            Name = "Vinh Nguyen",
            IdInfo = new IdInfo(666)
        };

        // Perform a shallow copy of p1 and assign it to p2.
        VinhPerson p2 = p1.ShallowCopy();
        // Make a deep copy of p1 and assign it to p3.
        VinhPerson p3 = p1.DeepCopy();

        // Display values of p1, p2 and p3.
        Console.WriteLine("Original values of p1, p2, p3:");
        Console.WriteLine("   p1 instance values: ");
        DisplayValues(p1);
        Console.WriteLine("   p2 (ShallowCopy) instance values:");
        DisplayValues(p2);
        Console.WriteLine("   p3 (DeepCopy) instance values:");
        DisplayValues(p3);

        // Change the value of p1 properties and display the values of p1,
        // p2 and p3.
        p1.Age = 28;
        p1.BirthDate = DateTime.UtcNow.AddYears(-28).AddMonths(-3).AddDays(5);
        p1.Name = "Tan";
        p1.IdInfo.IdNumber = 7878;
        Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
        Console.WriteLine("   p1 instance values: ");
        DisplayValues(p1);
        Console.WriteLine("   p2 instance values (reference values have changed):");
        DisplayValues(p2);
        Console.WriteLine("   p3 instance values (everything was kept the same):");
        DisplayValues(p3);

        Console.ReadLine();
    }

    private static void DisplayValues(VinhPerson p)
    {
        Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.Age, p.BirthDate);
        Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
    }
}