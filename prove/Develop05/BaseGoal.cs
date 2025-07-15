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
        _status = false;
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
    public int GetPoints()
    {
        return _points;
    }

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

    public abstract string StringForGoalFile();
    // {
    //     return $"{_status}#{_name}#{_description}#{_points}"; // fix this  bc each goal needs to be overrid
    // }
    public virtual void DisplayEndMessage()
    {
        int total_sum =  _points;
        Console.Write($"Congradulations! You have earned {total_sum}points!");
        Console.Write($"You now have {total_sum}");
    }// did i do this right?
    
}