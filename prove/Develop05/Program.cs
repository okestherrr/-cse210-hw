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
                    Console.WriteLine("What goal type is this?( Eternal, Checklist, or Simple) ");
                    string goalType = Console.ReadLine().ToLower();
                    Console.WriteLine("what is the name of the goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("what is a short description of the goal? ");
                    string desciption = Console.ReadLine();
                    Console.WriteLine("How many points do you want with this goal");
                    int points = int.Parse(Console.ReadLine());


                    if (goalType == "checklist")
                    {
                        Console.WriteLine("How many times does this goal need to be accomplished? ");
                        int max = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is the bonus for accomplshing this goal that many times? ");
                        int bonus = int.Parse(Console.ReadLine());

                        // fix this with competion and max

                        ChecklistGoal checklistGoal = new ChecklistGoal(name, desciption, points,false, bonus,max);// add completion and max later
                        goal.AddGoals(checklistGoal);
                    }
                    else if (goalType == "eternal")
                    {
                        // do the same as checklist goals but with completions and are zero
                        EternalGoal eternalGoal = new EternalGoal(name, desciption, points, 0);
                        goal.AddGoals(eternalGoal);
                    }
                    else if (goalType == "simple")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(name, desciption, points);

                        goal.AddGoals(simpleGoal);
                    }
                    
                    // make goal and put goal into list of goals
                    break;
                case 2:// display and list goals
                  goal.DisplayGoals();
                  goal.DisplayScore();// confirm this

                    break;
                case 3://save goals
                    Console.WriteLine("What is the filename for the goal file? ");
                    //call savetofile then pass it in
                    string filename = Console.ReadLine();
                    goal.SendToFile(filename);

                    // save to that file- help

                    break;

                case 4: //load goals
                    Console.WriteLine("What is the filename for the goal file? ");
                    string Savefiles = Console.ReadLine();
                    //help complete this
                    goal.DisplayScore();
                    break;

                case 5://recordevent 
                    goal.DisplayGoals();
                    Console.WriteLine("What goal did you accomplish? ");
                    
                    int completion = int.Parse(Console.ReadLine());
                    goal.CompleteGoal(completion);

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