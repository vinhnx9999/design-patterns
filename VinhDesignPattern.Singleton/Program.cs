namespace VinhDesignPattern.Singleton;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Singleton Design Pattern!");

        var singleton1 = VinhSingleton.GetInstance("Vinh-Nguyen");
        var singleton2 = VinhSingleton.GetInstance("Vinhnx9999");

        Console.WriteLine("\n*****************************************************************************************************\n");

        Console.WriteLine("Hello, singleton 01");
        singleton1.SomeBusinessLogic();

        Console.WriteLine("\n*****************************************************************************************************\n");
        Console.WriteLine("Hello, singleton 02");
        singleton2.SomeBusinessLogic();

        Console.WriteLine("\n*****************************************************************************************************\n");
        if (singleton1 == singleton2)
        {
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables contain different instances.");
        }

        Console.WriteLine("\n*****************************************************************************************************\n");

        Thread process1 = new(() => TestSingleton("FOO"));
        Thread process2 = new(() => TestSingleton("BAR"));

        Console.WriteLine("Hello, singleton FOO");
        process1.Start();
        Console.WriteLine("Hello, singleton BAR");
        process2.Start();

        Console.WriteLine("\n*****************************************************************************************************\n");
        process1.Join();
        process2.Join();

        Console.ReadLine();
    }

    public static void TestSingleton(string value)
    {
        var singleton = VinhSingleton.GetInstance(value); 
        Console.WriteLine(singleton.Value);
    }
}
