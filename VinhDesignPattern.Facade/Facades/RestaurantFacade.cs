using VinhDesignPattern.Facade.Implementations;
using VinhDesignPattern.Facade.Interfaces;

namespace VinhDesignPattern.Facade.Facades;

public class RestaurantFacade
{
    private readonly IPizza _pizzaProvider;
    private readonly IBread _breadProvider;

    public RestaurantFacade()
    {
        _pizzaProvider = new PizzaProvider();
        _breadProvider = new BreadProvider();
    }

    public void GetNonVegPizza() => _pizzaProvider.GetNonVegPizza();

    public void GetVegPizza() => _pizzaProvider.GetVegPizza();

    public void GetGarlicBread() => _breadProvider.GetGarlicBread();

    public void GetCheesyGarlicBread() => _breadProvider.GetCheesyGarlicBread();
}
