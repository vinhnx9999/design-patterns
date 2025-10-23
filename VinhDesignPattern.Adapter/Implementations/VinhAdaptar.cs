using VinhDesignPattern.Adapter.Interfaces;

namespace VinhDesignPattern.Adapter.Implementations;

public class VinhAdaptar : IVinhTarget
{
    public List<string> GetResponses()
    {
        return new ResponsesStore().GetDumpRecieved();
    }
}
