using System;

public class ChecklistGoal : BaseGoal
{
    private readonly int _bonus;
    private readonly int _maxTimes;
    private int _current;// is this the status?

  

    public ChecklistGoal(string name, string description, int points, bool status, int current, int max) : base(name, description, points, "Checklist")
    {
      
        _maxTimes = max;
        _current = 0;
    }
    public ChecklistGoal(string name, string description, int points, bool status, int current, int max, int bonus) : base(name, description, points, status, "Checklist")
    {
        _bonus = bonus;
        _current = current;
        _maxTimes = max;
        _current = 0;
    }
    // public override string CountBonus()// includes count and bonuses in the formatedDisplay
    // {
    // }
    public override void PopulateGoal()
    {
    }
    public override string StringForGoalFile()
    {
        return $"CLG#{_name}#{_description}#{_points}#{_status}#{_current}#{_maxTimes}#{_bonus}";
    }
    public override int RecordEvent()
    {
        _current++;
        if (_current >= _maxTimes)
        {
            _status = true;
            return _points + _bonus;
        }
        return _points;
    }
    public override string ToString()
    {
        return $"{(_status ? "[X]" : "[ ]")} {_name} ({_description}) -- Currently completed: {_current}/{_maxTimes}";
    }
    public override void DisplayEndMessage()
    {
        int total_sum = _bonus + _points;
        Console.Write($"Congradulations! You have earned {_bonus}points!");
        Console.Write($"You now have {total_sum}.");
    }// did i do this right?

}