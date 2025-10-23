using VinhDesignPattern.Strategy.Interfaces;
namespace VinhDesignPattern.Strategy.Implementations;

public class BikeStrategy : IStrategy
{
    public string GetTravelTime(string source, string destination)
    {
        return "It takes 95 minutes to reach from " + source + " to " + destination + " using Bike.";
    }
}
