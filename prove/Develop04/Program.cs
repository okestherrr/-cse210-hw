using System;
using System.Globalization;

//will have the menue and program with main void
public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int choice = DisplayMenu();

            Console.Clear();

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case 2:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case 3:
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;
                case 4:
                    Console.WriteLine("Bye!");
                    return;
                default:
                    Console.WriteLine("Not available. Try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
            Console.Clear();
        }
    }
    /* This method will print the menu and ask the user for her choice. */
    private static int DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing Activity");
            Console.WriteLine("2. Start reflection Activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
            }
        }
    } 
}