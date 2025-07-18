using System;

public class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool status) : base(name, description, points,status, "Simple")
    {
    }

    public override void PopulateGoal()
    {
    }
    public override string StringForGoalFile()
    {
        return $"SG#{_name}#{_description}#{_points}#{_status}";
    }
    public override int RecordEvent()
    {
        _status = true;
        return _points;
    }
    public override string ToString()
    {
        return $"{(_status ? "[X]" : "[ ]")} {_name} ({_description})";
    }
    
   
}