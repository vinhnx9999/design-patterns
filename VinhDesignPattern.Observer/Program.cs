using VinhDesignPattern.Observer.Implementations;

namespace VinhDesignPattern.Observer;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var subject = new VinhSubject();
        var observerA = new VinhObserver("Observer A");
        var observerB = new VinhObserver("Observer B");
        var observerC = new VinhObserver("Observer C");

        Console.WriteLine("Intially suppose Subject has already written total " + subject.Articles + " article");
        Console.WriteLine("\n*******************************************************************************\n");

        Console.WriteLine("Registering observers A and B for future articles...............");
        subject.RegisterObserver(observerA);
        subject.RegisterObserver(observerB);
        Console.WriteLine("New article published by Subject,so now observers A and B will be notified....\n");
        subject.Articles++;

        Console.WriteLine("---------------------------------------------------------------------------\n");
        Console.WriteLine("Registering observer C for future articles and unregistering observer B from the future articles...............");
        subject.RegisterObserver(observerC);
        subject.UnregisterObserver(observerB);

        Console.WriteLine("New article published by Subject,so now observers A and C will be notified....\n");
        subject.Articles++;

        Console.WriteLine("\n*******************************************************************************\n");
        Console.WriteLine("Finally Subject has written total " + subject.Articles + " article \n");

        Console.ReadLine();
    }
}
