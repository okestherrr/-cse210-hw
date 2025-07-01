using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Goal goal = new Goal();
        string menuSelection = "";

        while (menuSelection != "6")
        {
            Console.Write("Menu Opions: ");
            Console.Write("Select a choice from the menu: ");
            menuSelection = Console.ReadLine();
            switch (menuSelection)
            {
                case "1":// create new goal
                Goal NewGoal = new Goal();
                // make and put into list of goals

                    break;
                case "2":// list goals

                    break;
                case "3"://save goals

                    break;

                case "4": //load goals

                    break;

                case "5"://recod event

                    break;
                    
                case "6"://quit
                    break;
                
                
                


                }
        }
    }
}