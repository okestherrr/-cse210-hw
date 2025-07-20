using System;
public abstract class BaseGoal
    {
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _status;
    private string _goalType;

    public BaseGoal(string name, string description, int points, bool status, string goalType)
        {
        _name = name;
        _description = description;
        _points = points;
        _status = false;
        _goalType = goalType;
        }

    public abstract void PopulateGoal();
    public abstract string GetDetails();

    public abstract bool IsComplete();  
    public abstract string ToRecord();
    public abstract void RecordEvent(ref int totalPoints);
   
    //  public virtual string DisplayGoal()
    // {
    //     string mark = _status ? "X" : " ";
    //     return $"[{mark}] {_name} ({_description})";
    // }
    // public virtual string MarkDone()
    // {
    //     if (_status)
    //     {
    //         return "[X]";
    //     }
    //     else
    //     {
    //         return "[ ]";
    //     }

    // }
    public int GetPoints()
    {
        return _points;
    }

    public string GetGoalName()
    {
        return _name;
    }
    // public void Setname(string name)
    // {
    //     _name = name;
    // }

    public string GetDescription()
    {
        return _description;
    }

    // public void SetDescription(string description)
    // {
    //     _description = description;
    // }
    // public void SetPoints(int points)
    // {
    //     _points = points;
    // }
    public virtual string GetGoalType()
     {
        return _goalType;
     }
    // public abstract override string ToString();
    // // {
    // //     return $"{MarkDone()} {GetName()} ({GetDescription()})";
    // // }

    public virtual string StringForGoalFile()
    {
        return $"{_goalType}#{_name}#{_description}#{_points}#{_status}";
    }
  public virtual void DisplayEndMessage()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }// did i do this right?
    
}