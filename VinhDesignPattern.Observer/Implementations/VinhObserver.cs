using VinhDesignPattern.Observer.Interfaces;

namespace VinhDesignPattern.Observer.Implementations;

public class VinhObserver(string name) : IObserver
{
    public string ObserverName = name;

    public void Update()
    {
        //Observer can update his system accordingly  
        Console.WriteLine("Hello " + ObserverName + ", a new article has been published by the author.");
    }
}
