using System;
using System.ComponentModel;
using System.Numerics;
public abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;
    private string _goalType;
    public BaseGoal()
    {
        _name = "";
        _description = "";
        _status = false;
        _goalType = "";

    }

    public BaseGoal(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status;
        _goalType = goalType;

    }

    public abstract int RecordEvent();

    public abstract void PopulateGoal();
    public virtual string MarkDone()//displays goal details with status
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
    public abstract int GetPoints();//gets point value of goal

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
    public int Getpoints()
    {
    
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    

    public virtual string GetGoalType()
    {
        return _goalType;
    }
    public override string ToString()
    {
        return $"{MarkDone} {_description}";
    }

    public virtual string StringforGoalFile()
    {
        return $" {_description}"; // fix this 
    }
    
}