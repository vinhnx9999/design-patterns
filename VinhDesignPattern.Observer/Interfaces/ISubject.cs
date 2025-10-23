namespace VinhDesignPattern.Observer.Interfaces;
using VinhDesignPattern.Observer.Implementations;

public interface ISubject
{
    void RegisterObserver(VinhObserver observer);
    void UnregisterObserver(VinhObserver observer);
    void NotifyObservers();
}