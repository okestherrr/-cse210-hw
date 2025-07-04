using System;

public class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points, "Simple")
    {
    }

    public override void PopulateGoal()
    {
    }
    public override string StringforGoalFile()
    {
        return $"SG#{_status}#{_name}#{_description}#{_points}";
    }
    public override int RecordEvent()
    {
        _status = true;
        return _points;
    }

    public override int GetPoints()
    {
        return _points;
    }
    public override string ToString()
    {
        return $"{(_status ? "[X]" : "[ ]")} {_name} ({_description})";
    }
    
   
}