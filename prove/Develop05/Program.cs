using System;

public class Program
{
    static Allgoals goal = new Allgoals();
    static void Main(string[] args)
    {
        while (true)
        {
            int choice = DisplayMenu();

            Console.Clear();

            switch (choice)
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

                    if (goalType == "Checklist")
                    {
                        Console.WriteLine("What is the bonus? ");
                        int bonus = int.Parse(Console.ReadLine());
                        // get max and other thng

                        ChecklistGoal checklistGoal = new ChecklistGoal(name, desciption, points, false, bonus);// add completion and max later
                    }
                    else if (goalType == "Eternal")
                    {
                        // do the same as checklist goals but with completions and are zero
                    }
                    else if ( goalType == "Simple")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(name, desciption, points);
                    }
                    
                    // make goal and put goal into list of goals
                    break;
                case 2:// display and list goals
                   goal.DisplayGoals();// confirm this

                    break;
                case 3://save goals

                    break;

                case 4: //load goals
                    Console.WriteLine("What is the filename to load? ");
                    string Savefiles = Console.ReadLine();
                    //help complete this

                    break;

                case 5://recordevent 

                    break;

                case 6:
                    Console.WriteLine("Bye!");
                    break;

            }
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
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
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