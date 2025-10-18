namespace VinhDesignPattern.Factory.Models;

public class Cruise : Vehicle
{
    public Cruise() => base.capacity = 300;
    public override VehicleType GetVehicleType() => VehicleType.Cruise;
}