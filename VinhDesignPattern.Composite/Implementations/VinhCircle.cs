using VinhDesignPattern.Composite.Interfaces;

namespace VinhDesignPattern.Composite.Implementations;

public class VinhCircle: IVinhDraw
{
    public void Draw()
    {
        Console.WriteLine("I am a Circle");
    }
}
