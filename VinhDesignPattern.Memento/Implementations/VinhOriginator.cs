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
        this._state = this.GenerateRandomString(30);
        Console.WriteLine($"Originator: and my state has changed to: {_state}");
    }

    private string GenerateRandomString(int length = 10)
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
        return new ConcreteMemento(this._state);
    }

    public void Restore(IVinhMemento memento)
    {
        if (memento is not ConcreteMemento)
        {
            throw new Exception("Unknown memento class " + memento.ToString());
        }

        this._state = memento.GetState();
        Console.Write($"Originator: My state has changed to: {_state}");
    }
}