using VinhDesignPattern.Decorator.Implementations;

namespace VinhDesignPattern.Decorator;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Decorator Design Pattern!");
        Console.WriteLine("\n*****************************************************************************************************\n");

        VinhCar objCarAC = new WithAC();
        Console.WriteLine("Hello, Car with AC");
        objCarAC.CarType();

        Console.WriteLine("\n*****************************************************************************************************\n");
        Console.WriteLine("Hello, Car with sound system and AC");
        VinhCar objCarAll = new WithSoundSystemAndAC();
        objCarAll.CarType();

        Console.ReadLine();
    }
}
