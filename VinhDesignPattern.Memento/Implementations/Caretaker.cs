using VinhDesignPattern.Memento.Interfaces;

namespace VinhDesignPattern.Memento.Implementations;

public class Caretaker(VinhOriginator originator)
{
    private readonly List<IVinhMemento> _mementos = [];

    private readonly VinhOriginator _originator = originator;

    public void Backup()
    {
        Console.WriteLine("\nCaretaker: Saving Originator's state...");
        _mementos.Add(_originator.Save());
    }

    public void Undo()
    {
        if (_mementos.Count == 0)
        {
            return;
        }

        var memento = _mementos.Last();
        _mementos.Remove(memento);

        Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

        try
        {
            _originator.Restore(memento);
        }
        catch (Exception)
        {
            Undo();
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("Caretaker: Here's the list of mementos:");
        foreach (var memento in _mementos)
        {
            Console.WriteLine(memento.GetName());
        }
    }
}
