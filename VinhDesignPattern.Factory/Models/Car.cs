namespace VinhDesignPattern.Factory.Models;

public class Car : Vehicle
{
    public Car() => base.capacity = 5;
    public override VehicleType GetVehicleType() => VehicleType.Car;
}
