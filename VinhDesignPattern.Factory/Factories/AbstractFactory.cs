using VinhDesignPattern.Factory.Models;

namespace VinhDesignPattern.Factory.Factories;

public abstract class AbstractFactory
{
    public abstract Vehicle CreateLandVehicle();
    public abstract Vehicle CreateSeaVehicle();
}

class LargeGroupFactory : AbstractFactory
{
    public override Vehicle CreateLandVehicle()
    {
        return new Bus();
    }

    public override Vehicle CreateSeaVehicle()
    {
        return new Cruise();
    }
}

class SmallGroupFactory : AbstractFactory
{
    public override Vehicle CreateLandVehicle()
    {
        return new Car();
    }

    public override Vehicle CreateSeaVehicle()
    {
        return new Boat();
    }
}