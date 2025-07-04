using System;
public abstract class BaseGoal
{
    public string _name;
    public string _description;
    public int _points;
    public bool _status;
    private string _goalType;
    // public BaseGoal()
    // {
    //     _name = "";
    //     _description = "";
    //     _status = false;
    //     _goalType = "";

    // }

    public BaseGoal(string name, string description, int points, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _status =false;
        _goalType = goalType;

    }

    public abstract int RecordEvent();
    public abstract void PopulateGoal();
    public virtual string MarkDone()
    {
        if (_status)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }

    }
    public abstract int GetPoints();

    public string GetName()
    {
        return _name;
    }
    public void Setname(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }
    public abstract int Getpoints();
    // {
    //     return _points;
    // }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public virtual string GetGoalType()
    {
        return _goalType;
    }
    public abstract override string ToString();
    // {
    //     return $"{MarkDone()} {GetName()} ({GetDescription()})";
    // }

    public abstract string StringforGoalFile();
    // {
    //     return $"{_status}#{_name}#{_description}#{_points}"; // fix this  bc each goal needs to be overrid
    // }
    
}