
namespace VinhDesignPattern.Singleton;

public sealed class VinhSingleton
{
    private static readonly Lock _lock = new();  
    private static VinhSingleton? _instance;
    public static VinhSingleton GetInstance(string value)
    {
        if (_instance == null)
        {
            lock (_lock)
            {                
                _instance ??= new VinhSingleton
                    {
                        Value = value
                    };
            }
        }
        return _instance;
    }

    public string Value { get; set; } = string.Empty;

    public void SomeBusinessLogic()
    {
        Console.WriteLine($"[{Value}] Some BusinessLogic");
    }
}