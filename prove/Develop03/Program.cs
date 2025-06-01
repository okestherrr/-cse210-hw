using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of scriptures
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life."),
            
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            
            new Scripture(new Reference("Romans", 5, 8),
                "But God demonstrates his own love for us in this: While we were still sinners, Christ died for us."),
            
            new Scripture(new Reference("Ephesians", 2, 8, 9),
                "For it is by grace you have been saved, through faith—and this is not from yourselves, it is the gift of God—not by works, so that no one can boast.")
        };

        // Pick one randomly
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        string userInput = "";
        bool quitEarly = false;

        while (userInput != "q" && !scripture.AllHiddenWordsCheck())
        {
            Console.Clear();
            Console.WriteLine("Press Enter to continue or type 'q' to quit.\n");
            Console.WriteLine(scripture.DisplayHiddenText());
            userInput = Console.ReadLine();

            if (userInput == "q")
            {
                quitEarly = true;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        if (quitEarly)
        {
            Console.WriteLine("Better luck next time!");
        }
        else
        {
            Console.WriteLine("Congrats on finishing studying!");
        }
    }
}
