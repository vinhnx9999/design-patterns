using VinhDesignPattern.Memento.Implementations;

namespace VinhDesignPattern.Memento;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Memento Design Pattern!");
        string userName = "Vinh Nguyen";
        int numLoop = 5;

        VinhOriginator originator = new(userName);
        Caretaker caretaker = new(originator);

        for (int i = 0; i < numLoop; i++)
        {
            caretaker.Backup();
            originator.DoSomething();
        }

        Console.WriteLine();
        caretaker.ShowHistory();

        Console.WriteLine($"\n{userName}: Now, let's rollback!\n");
        caretaker.Undo();

        for (int i = 1; i < numLoop - 1; i++)
        {
            Console.WriteLine($"\n\n{userName}: Once more again, please\n");
            caretaker.Undo();
        }           

        Console.WriteLine();
        Console.ReadLine();
    }
}
