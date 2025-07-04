using System;

public class Program
{
    static void Main(string[] args)
    {
        Allgoals Goals = new Allgoals();
        while (true)
        {
            int menuSelection = DisplayMenu();

            Console.Clear();

            switch (menuSelection)
            {
                case 1:// create new goal
                    Console.WriteLine("what is the goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("what is the description of the goal? ");
                    string desciption = Console.ReadLine();
                    Console.WriteLine("How many points do you want with this goal");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine("What goal type is this?( Eternal, Checklist, or Simple) ");
                    string goalType = Console.ReadLine();

                    BaseGoal newGoal = new BaseGoal(name, desciption, points, goalType);
                  
                    
                    //fix this
                    // make goal and put goal into list of goals
                    break;
                case 2:// display and list goals
                    Goals.DisplayGoals();// confirm this

                    break;
                case 3://save goals

                    break;

                case 4: //load goals
                    Console.WriteLine("What is the filename to load? ");
                    string Savefiles = Console.ReadLine();
                  //help complete this

                    break;

                case 5://record event

                    break;

                case 6://quit
                    Console.WriteLine("Bye!");
                    break;

            }
            // Console.WriteLine("\nPress Enter to return to the menu...");
            // Console.ReadLine();
            // Console.Clear();
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