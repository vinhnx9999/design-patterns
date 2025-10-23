using VinhDesignPattern.Memento.Interfaces;

namespace VinhDesignPattern.Memento.Implementations;

public class VinhOriginator
{
    private string _state;

    public VinhOriginator(string state)
    {
        _state = state;
        Console.WriteLine("Originator: My initial state is: " + state);
    }

    public void DoSomething()
    {
        Console.WriteLine("Originator: I'm doing something important.");
        _state = GenerateRandomString(30);
        Console.WriteLine($"Originator: and my state has changed to: {_state}");
    }

    private static string GenerateRandomString(int length = 10)
    {
        string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string result = string.Empty;

        while (length > 0)
        {
            result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

            Thread.Sleep(12);

            length--;
        }

        return result;
    }

    public IVinhMemento Save()
    {
        return new ConcreteMemento(_state);
    }

    public void Restore(IVinhMemento memento)
    {
        if (memento is not ConcreteMemento)
        {
            throw new ArgumentException($"Unknown memento class {memento}");
        }

        _state = memento.GetState();
        Console.Write($"Originator: My state has changed to: {_state}");
    }
}