using VinhDesignPattern.Strategy.Implementations;

namespace VinhDesignPattern.Strategy;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello!, Please select the mode of transport to get the travel time between source and destination: \nCar \nBike \nBus");
        
        Console.WriteLine("\n*****************************************************************************************************\n");
        string userStrategy = Console.ReadLine() ?? "";
        Console.WriteLine("\nUser has selected *" + userStrategy + "* as mode of transport\n");
        Console.WriteLine("\n*****************************************************************************************************\n");

        string fromAddr = "Ha Noi";
        string toAddr = "Thanh Hoa";

        string transportMode = userStrategy.ToLower();
        string result = transportMode switch
        {
            "car" => new TravelStrategy(new CarStrategy()).GetTravelTime(fromAddr, toAddr),
            "bike" => new TravelStrategy(new BikeStrategy()).GetTravelTime(fromAddr, toAddr),
            "bus" => new TravelStrategy(new BusStrategy()).GetTravelTime(fromAddr, toAddr),
            _ => throw new NotImplementedException(),
        };
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
