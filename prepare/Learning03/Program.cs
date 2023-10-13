using System;

class Program
{
    static void Main(string[] args)
    {
        FractionWriter test1 = new FractionWriter();
        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test1.GetDecimalValue());

        FractionWriter test2 = new FractionWriter(5);
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test2.GetDecimalValue());

        FractionWriter test3 = new FractionWriter(3, 4);
        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());

        FractionWriter test4 = new FractionWriter(1, 3);
        Console.WriteLine(test4.GetFractionString());
        Console.WriteLine(test4.GetDecimalValue());
    }
}