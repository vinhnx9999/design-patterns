using VinhDesignPattern.Facade.Facades;

namespace VinhDesignPattern.Facade;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Facade Design Pattern In C# ");

        Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");

        var facadeForClient = new RestaurantFacade();
        facadeForClient.GetNonVegPizza();
        facadeForClient.GetVegPizza();

        Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");

        facadeForClient.GetGarlicBread();
        facadeForClient.GetCheesyGarlicBread();

        Console.ReadLine();
    }
}
