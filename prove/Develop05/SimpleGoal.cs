using System;

public class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool status)
    : base(name, description, points, status, "Simple")
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

    public override string ToRecord()
    {
        return $"{GetGoalType()}|{_name}|{_description}|{_points}|{_status}";
    }
    // public override int RecordEvent()
    // {
    //     if (!_status)
    //     {
    //         _status = true;
    //         return _points;
    //     }
    //     return 0;
    // }
    public override string GetDetails()
    {
        string status = _status ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
        // should look like - u have completed (/)
    }
    public override void RecordEvent(ref int totalPoints)
    {
        if (!_status)
        {
            _status = true;
            totalPoints += _points;
            Console.WriteLine($"Congratulations! You earned {_points} points!");
        }
        else
        {
            Console.WriteLine("This goal is done.");
        }
    }

    public override bool IsComplete()
    {
        return _status;
    } 
}
   
