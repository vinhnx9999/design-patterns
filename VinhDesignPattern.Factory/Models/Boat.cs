namespace VinhDesignPattern.Factory.Models;

public class Boat : Vehicle
{
    public Boat() => base.capacity = 150;
    public override VehicleType GetVehicleType() => VehicleType.Boat;
}
