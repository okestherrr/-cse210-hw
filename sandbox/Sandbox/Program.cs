using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");     
        Console.Write("What is your first name?");
        string firstName = Console.ReadLine();
        Console.Write("What is your first name?");
        string lastName = Console.ReadLine();
        Console.Write($"Your name is {lastName}, {firstName}.");
    }
}

