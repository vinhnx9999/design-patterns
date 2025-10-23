using VinhDesignPattern.Composite.Interfaces;

namespace VinhDesignPattern.Composite.Implementations;

public class VinhOval : IVinhDraw
{
    public void Draw()
    {
        Console.WriteLine("I am an Oval");
    }
}