namespace VinhDesignPattern.Factory.Models;
public abstract class Vehicle
{
    internal int capacity;
    public string GetData()
    {
        var types = GetType().ToString().Split(".");
        return types[^1];
    }

    public int GetCapacity() => capacity;
    public abstract VehicleType GetVehicleType();

    public void AddPassengers(int passengers)
    {
        if (capacity < passengers)
        {
            throw new AggregateException(GetData() + " reached max capacity");
        }
        else
            capacity -= passengers;
    }
}
