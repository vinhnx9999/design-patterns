using VinhDesignPattern.Observer.Interfaces;

namespace VinhDesignPattern.Observer.Implementations;

public class VinhSubject : ISubject
{
    private readonly List<VinhObserver> _observers = [];
    private int articlesCount = 1;
    public int Articles
    {
        get
        {
            return articlesCount;
        }
        set
        {
            if (value > articlesCount)
            {
                articlesCount++;
                NotifyObservers();
            }
        }
    }

    public void RegisterObserver(VinhObserver observer)
    {
        _observers.Add(observer);
    }

    public void UnregisterObserver(VinhObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}
