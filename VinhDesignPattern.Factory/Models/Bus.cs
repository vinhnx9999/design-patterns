namespace VinhDesignPattern.Factory.Models;

public class Bus : Vehicle
{
    public Bus() => base.capacity = 50;
    public override VehicleType GetVehicleType() => VehicleType.Bus;
}