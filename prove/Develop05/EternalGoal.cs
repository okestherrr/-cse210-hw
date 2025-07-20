using System;
public class EternalGoal : BaseGoal
{
    public EternalGoal(string name, string description, int points, bool status)
    : base(name, description, points, status, "Eternal")
    {
    }

    public override void PopulateGoal()
    {
        Console.Write("Enter goal name: ");
        _name = Console.ReadLine();
        Console.Write("Enter description: ");
        _description = Console.ReadLine();
        Console.Write("Enter point value: ");
        _points = int.Parse(Console.ReadLine());
    }

    public override string GetDetails()
    {
        return $"[∞] {_name} ({_description})";
    }
    public override string ToRecord()
    {
        return $"{GetGoalType()}|{_name}|{_description}|{_points}";
    }
    public override void RecordEvent(ref int totalPoints)
    {
        totalPoints += _points;
        Console.WriteLine($"Great job! You earned {_points} points!");
    }
    public override bool IsComplete()
    {
        return false;
    } 

}