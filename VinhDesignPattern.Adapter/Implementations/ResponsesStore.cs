namespace VinhDesignPattern.Adapter.Implementations;

public class ResponsesStore
{
    public List<string> GetDumpRecieved()
    {
        var responses = new List<string>() {
            "This is a test response by user 1",
            "This is a test response by user 2",
            "This is a test response by user 3",
            "This is a test response by user 4"
        };
        return responses;
    }
}
