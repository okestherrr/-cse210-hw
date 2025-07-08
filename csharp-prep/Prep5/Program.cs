using System;

class Program
{
    static void TestByRef(int x, string n)
    {
        x++;
        n += "plus betty";
        Console.WriteLine($"In TestByRef: {x}, {n}");
    }
    
    static void Main(string[] args)
    {
        int x = 10;
        string name = "bob";

        TestByRef(ref x, ref name);

        Console.WriteLine($"in main: {x}, {name}");

    }
}