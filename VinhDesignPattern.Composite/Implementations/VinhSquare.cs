using VinhDesignPattern.Composite.Interfaces;

namespace VinhDesignPattern.Composite.Implementations;

public class VinhSquare : IVinhDraw
{
    public void Draw()
    {
        Console.WriteLine("I am a Square");
    }
}
