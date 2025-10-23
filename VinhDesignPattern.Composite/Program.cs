using System.Collections;
using VinhDesignPattern.Composite.Implementations;
using VinhDesignPattern.Composite.Interfaces;

namespace VinhDesignPattern.Composite;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Composite Design Pattern!");        

        IVinhDraw objcircl = new VinhCircle();
        IVinhDraw objSquare = new VinhSquare();
        IVinhDraw objOval = new VinhOval();

        ArrayList objList = [];
        objList.Add(objcircl);
        objList.Add(objSquare);
        objList.Add(objOval);

        foreach (IVinhDraw obj in objList)
        {
            obj.Draw();
        }

        Console.ReadLine();
    }
}
