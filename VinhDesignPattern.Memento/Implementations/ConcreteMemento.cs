using VinhDesignPattern.Memento.Interfaces;

namespace VinhDesignPattern.Memento.Implementations;

public class ConcreteMemento(string state) : IVinhMemento
{
    private readonly string _state = state;
    private readonly DateTime _date = DateTime.UtcNow;

    public string GetState() => _state;
    public string GetName() => $"{_date} / ({_state[..11]})...";
    public DateTime GetDate() => _date;
}
