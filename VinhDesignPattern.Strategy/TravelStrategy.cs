using VinhDesignPattern.Strategy.Interfaces;

namespace VinhDesignPattern.Strategy;

public class TravelStrategy(IStrategy chosenStrategy)
{
    private readonly IStrategy _strategy = chosenStrategy;

    public void GetTravelTime(string source, string destination)
    {
        var result = _strategy.GetTravelTime(source, destination);
        Console.WriteLine(result);
    }
}