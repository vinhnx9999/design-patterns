using VinhDesignPattern.Adapter.Interfaces;

namespace VinhDesignPattern.Adapter.Implementations;

public class VinhClient(IVinhTarget target)
{
    private readonly IVinhTarget _target = target;

    public List<string> GetResponsesRecieved()
    {
        return _target.GetResponses();
    }
}