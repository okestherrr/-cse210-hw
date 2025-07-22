using System;
using System.Collections.Generic;
using System.IO;
public class AllGoals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private int _totalPoints;

    public void AddGoal(BaseGoal goal) => _goals.Add(goal);

    public void ListGoals()
    {
        Console.WriteLine("Your goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }

    public void RecordGoalEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int choice) &&
            choice > 0 && choice <= _goals.Count)
        {
            _goals[choice - 1].RecordEvent(ref _totalPoints);
        }
        else
        {
            Console.WriteLine("WRONG");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
    }

    public void SaveGoals(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        writer.WriteLine(_totalPoints);
        foreach (var goal in _goals)
        {
            writer.WriteLine(goal.ToRecord());
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _totalPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            switch (type)
            {
                case "Simple":
                    bool simpleStatus = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), simpleStatus));
                    break;

                case "Eternal":
                    bool eternalStatus = bool.Parse(parts[4]);
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), eternalStatus));
                    break;

                case "Checklist":
                    int targetCount = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int currentCount = int.Parse(parts[6]);
                    bool checklistStatus = bool.Parse(parts[7]);
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), targetCount, bonus, checklistStatus, currentCount));
                    break;

            }
        }
    
    }
}


// public void GetFileName()
    // {
    //     Console.Write("Enter filename: ");
    //     _filename = Console.ReadLine();
    // }

