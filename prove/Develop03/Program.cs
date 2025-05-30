using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string userInput = "";
        Console.WriteLine(reference.GetDisplayText());
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life");
        while (userInput != "q")
        {

            Console.Clear();
            Console.WriteLine("Press Enter to keep going or q to quit.");
            scripture.DisplayHiddenText();

            userInput = Console.ReadLine();

        }// this is a conditional
         //study do and do whiles
        
       // this will loop with enter or end with q
    }

}