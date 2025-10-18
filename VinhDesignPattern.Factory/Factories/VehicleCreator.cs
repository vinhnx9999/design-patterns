using VinhDesignPattern.Factory.Models;

namespace VinhDesignPattern.Factory.Factories;

public abstract class VehicleCreator
{
    protected abstract Vehicle MakeVehicle();

    public Vehicle CreateVehicle()
    {
        return this.MakeVehicle();
    }
}

public class CruiseCreator : VehicleCreator
{
    protected override Vehicle MakeVehicle()
    {
        Vehicle vehicle = new Cruise
        {
            capacity = 300
        };
        return vehicle;
    }
}

public class BoatCreator : VehicleCreator
{
    protected override Vehicle MakeVehicle()
    {
        Vehicle vehicle = new Boat
        {
            capacity = 150
        };
        return vehicle;
    }
}

public class BusCreator : VehicleCreator
{
    protected override Vehicle MakeVehicle()
    {
        Vehicle vehicle = new Bus
        {
            capacity = 50
        };
        return vehicle;
    }
}

public class CarCreator : VehicleCreator
{
    protected override Vehicle MakeVehicle()
    {
        Vehicle vehicle = new Car
        {
            capacity = 5
        };
        return vehicle;
    }
}