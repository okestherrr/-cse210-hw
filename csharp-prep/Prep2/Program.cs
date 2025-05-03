using System;

class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage?(ex:55) ");
        string userPerc = Console.ReadLine();
        int grade = int.Parse(userPerc);

        string letter;

        if (grade >= 90)
        {
           letter = "A";
           Console.WriteLine("Great you passed!");
        }
        else if (grade >= 80)
        {
           letter = "B";
           Console.WriteLine("Great you passed!");
        }
        else if (grade >= 70)
        {           
            letter = "C";
            Console.WriteLine("Great you passed!");
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine("U failed");
        }
        else
        {
            letter = "F";
            Console.WriteLine("U failed");  
        } 
        Console.WriteLine($"Your grade is: {letter}");
    }
}