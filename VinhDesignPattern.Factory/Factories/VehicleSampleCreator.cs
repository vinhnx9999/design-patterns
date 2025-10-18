using VinhDesignPattern.Factory.Models;

namespace VinhDesignPattern.Factory.Factories;

public class VehicleSampleCreator
{
    public static Vehicle GetVehicle(int passengers)
    {
        return passengers switch
        {
            <= 5 => new Car(),
            > 5 and <= 50 => new Bus(),
            > 50 and <= 150 => new Boat(),
            _ => new Cruise(),
        };
    }
}
