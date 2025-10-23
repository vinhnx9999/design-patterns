using VinhDesignPattern.Adapter.Implementations;

namespace VinhDesignPattern.Adapter;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Adapter Design Pattern!");

        var client = new VinhClient(new VinhAdaptar());
        var userResponses = client.GetResponsesRecieved();

        userResponses.ForEach(res => Console.WriteLine($"{res}"));

        Console.ReadLine();
    }
}

