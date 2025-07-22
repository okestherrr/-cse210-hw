using System;

public class ChecklistGoal : BaseGoal
{
    private int _targetCount;
    private int _bonus;
    private int _currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, bool status, int currentCount = 0)
        : base(name, description, points, "Checklist", status)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = currentCount;
    }

}
    public override void PopulateGoal()
    {
        Console.Write("Enter goal name: ");
        _name = Console.ReadLine();
        Console.Write("Enter description: ");
        _description = Console.ReadLine();
        Console.Write("Enter point value: ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("Enter target count: ");
        _targetCount = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus for completing all: ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override string GetDetails()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string ToRecord()
{
    return $"Checklist|{_name}|{_description}|{_points}|{_targetCount}|{_bonus}|{_currentCount}|{_status}";
}

    public override void RecordEvent(ref int totalPoints)
    {
        if (!IsComplete())
        {
            _currentCount++;
            totalPoints += _points;
            Console.WriteLine($"You earned {_points} points!");
            if (_currentCount == _targetCount)
            {
                totalPoints += _bonus;
                Console.WriteLine($"Bonus! You completed the checklist and earned {_bonus} extra points!");
            }
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    } 
}
