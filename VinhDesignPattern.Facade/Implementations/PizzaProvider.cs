using VinhDesignPattern.Facade.Interfaces;

namespace VinhDesignPattern.Facade.Implementations;

public class PizzaProvider : IPizza
{
    public void GetNonVegPizza()
    {
        GetNonVegToppings();
        Console.WriteLine("Getting Non Veg Pizza.");
    }

    public void GetVegPizza()
    {
        Console.WriteLine("Getting Veg Pizza.");
    }

    private static void GetNonVegToppings()
    {
        Console.WriteLine("Getting Non Veg Pizza Toppings.");
    }
}
