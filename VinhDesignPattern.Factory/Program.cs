using VinhDesignPattern.Factory.Factories;
using VinhDesignPattern.Factory.Models;

namespace VinhDesignPattern.Factory;

public class Program
{
    public static void Main(string[] args)
    {
        Random rand = new();
        Console.WriteLine("Hello, DesignPatternFactory!");
        int passengers = rand.Next(1, 300);

        Console.WriteLine($"Number of passengers is {passengers}");
        Console.WriteLine("");
        Console.WriteLine("================= Creator =================");
        var vehicle = VehicleSampleCreator.GetVehicle(passengers);
        Console.WriteLine($"{vehicle.GetData()} is the maximum number of people: {vehicle.GetCapacity()}");

        vehicle.AddPassengers(passengers);
        Console.WriteLine($"Vehicle Type: {vehicle.GetData()}. With left capacity of: {vehicle.GetCapacity()}");

        Console.WriteLine("");
        Console.WriteLine("================= Abstract Factory =================");
        AbstractFactory factory;
        if (passengers <= 15)
            factory = new SmallGroupFactory();
        else
            factory = new LargeGroupFactory();

        var landVehicle = factory.CreateLandVehicle();
        var seaVehicle = factory.CreateSeaVehicle();

        Console.WriteLine("Land Vehicle : " + landVehicle.GetData() + ". With capacity of: " + landVehicle.GetCapacity());
        Console.WriteLine("Sea Vehicle : " + seaVehicle.GetData() + ". With capacity of: " + seaVehicle.GetCapacity());

        Console.WriteLine("");
        Console.WriteLine("================= Factory Method =================");
                
        var type = passengers switch
        {
            <= 5 => VehicleType.Car,
            > 5 and <= 50 => VehicleType.Bus,
            > 50 and <= 150 => VehicleType.Boat,
            > 150 => VehicleType.Cruise
        };

        var vehicleFactory = type switch
        {
            VehicleType.Boat => new BoatCreator().CreateVehicle(),
            VehicleType.Bus => new BusCreator().CreateVehicle(),
            VehicleType.Car => new CarCreator().CreateVehicle(),
            VehicleType.Cruise => new CruiseCreator().CreateVehicle(),
            _ => null,
        };

        Console.WriteLine(vehicleFactory.GetData());
        Console.WriteLine("Vehicle capacity: " + vehicleFactory.GetCapacity());

        Console.ReadLine();
    }

}
