using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int num;
        Console.Write("Enter a list of numbers, type 0 when finished. ");
        
        do
        {
            Console.WriteLine("Enter number: ");
            string text = Console.ReadLine();
            num = int.Parse(text);

            if (num != 0)
            {
                numbers.Add(num);
            }
        while (num != 0);
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // find avg and lg and sort
        Console.Write($"The sum is: {sum}");
        Console.Write($"The average is: {avg}");
        Console.Write($"The largest number is: {lgn}");
        Console.Write("The sorted list:");
        Console.WriteLine(numbers, count);
        
    }
}