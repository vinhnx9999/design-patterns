namespace VinhDesignPattern.Decorator.Implementations;

public class WithAC : VinhCar
{
    public override void CarType()
    {
        Console.Write("AC Car");
    }
}
