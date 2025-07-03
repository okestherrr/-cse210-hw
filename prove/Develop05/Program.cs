using System;

public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int menuSelection = DisplayMenu();

            Console.Clear();

            switch (menuSelection)
            {
                case 1:// create new goal
                    BaseGoal newGoal = new BaseGoal();
                    newGoal.// fix this
                    // make goal and put goal into list of goals
                    break;
                case 2:// list goals

                    break;
                case 3://save goals

                    break;

                case 4: //load goals

                    break;

                case 5://record event

                    break;

                case 6://quit
                    Console.WriteLine("Bye!");
                    break;

            }
            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
            Console.Clear();
        }
    }
    private static int DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("3. Load Goals");
            Console.WriteLine("3. Record Goals");
            Console.WriteLine("4. Quit");
            Console.Write("Please select a choice from the menu: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
            }
        }

    }
    
}