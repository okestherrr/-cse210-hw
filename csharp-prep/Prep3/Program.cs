using System;
class Program
{
    static int GetInt(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();

        bool validInt = int.TryParse(input, out int number);

        if (validInt) return number;

        Console.WriteLine("Not a number, try again.");
        return GetInt(prompt);

    }
    
    static void Main(string[] args)
    {
        Random randomGenerator = new();
        int ranNum = randomGenerator.Next(1, 101);
        //Console.WriteLine("Hello Prep3 World!");
        // Console.WriteLine("What is the magic number? ");
        int guess = -1;
        while (guess != ranNum)
        {
            guess = GetInt("What is your guess? ");
            
            if (guess > ranNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < ranNum)
            {
                Console.WriteLine("Higher");
            }
        }
       
        Console.WriteLine("You guessed it!");
    }
}