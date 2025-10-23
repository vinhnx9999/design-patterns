namespace VinhDesignPattern.Decorator.Implementations;

public class WithSoundSystemAndAC : WithAC
{
    public override void CarType()
    {
        base.CarType();
        Console.WriteLine("With Sound system");
    }
}