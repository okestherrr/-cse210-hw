using System;

class Program
    {
    static void Main(string[] args)
    {
        AllGoals manager = new AllGoals();

        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display score");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("The type of goals are: ");
                    Console.WriteLine("1. Simple");
                    Console.WriteLine("2. Eternal");
                    Console.WriteLine("3. Checklist");
                    Console.WriteLine("Which type of goal do you want to do? ");
                    string typeChoice = Console.ReadLine();
                    BaseGoal newGoal = null;
                    switch (typeChoice)
                    {
                        case "1":
                            newGoal= new SimpleGoal("", "", 0, false);
                            
                            break;
                        case "2":
                           newGoal=  new EternalGoal("", "", 0, false);
                            break;
                        case "3":
                            newGoal= new ChecklistGoal("", "", 0, 0, 0, false);
                            break;
                    }
                    if (newGoal != null)
                    {
                        newGoal.PopulateGoal();
                        manager.AddGoal(newGoal);
                    }
                break;
                case "2":
                    manager.ListGoals();
                break;

                case "3":
                    Console.Write("Enter filename to save to: ");
                    manager.SaveGoals(Console.ReadLine());
                break;

                case "4":
                    Console.Write("Enter filename to load from: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;

                case "5":
                    manager.RecordGoalEvent();
                    break;

                case "6":
                    manager.DisplayScore();
                    break;

                case "7":
                    return;

                default:
                    Console.WriteLine("NOPE INVALID.");
                break;
            }
        }
}
}
