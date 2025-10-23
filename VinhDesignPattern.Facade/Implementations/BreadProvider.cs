using VinhDesignPattern.Facade.Interfaces;

namespace VinhDesignPattern.Facade.Implementations;

public class BreadProvider : IBread
{
    public void GetGarlicBread()
    {
        Console.WriteLine("Getting Garlic Bread.");
    }

    public void GetCheesyGarlicBread()
    {
        GetCheese();
        Console.WriteLine("Getting Cheesy Garlic Bread.");
    }

    private static void GetCheese()
    {
        Console.WriteLine("Getting Cheese.");
    }
}