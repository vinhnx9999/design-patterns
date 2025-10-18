using VinhDesignPattern.Bridge.Conceptual;

Console.WriteLine("Hello, Design Pattern Bridge!");

Abstraction abstraction;
// The client code should be able to work with any pre-configured
// abstraction-implementation combination.
abstraction = new Abstraction(new ConcreteImplementationA());
Client.ClientCode(abstraction);

Console.WriteLine();

abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
Client.ClientCode(abstraction);

Console.ReadLine();
