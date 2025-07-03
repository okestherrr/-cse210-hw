using System;
using System.ComponentModel;
using System.Numerics;
public abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private string _filename;

    private bool _status;
    private string _goalType;



    public BaseGoal(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status;
        _goalType = goalType;

    }

    public abstract int RecordEvent();//handles completed goal- is abstract so doesnt need any parameters


    public abstract bool IsDone();// checks if goal is done or not
                                  // leave empty because every goals "is done" will be different( eternal wont ever be done)


    public virtual string MarkDone()//displays goal details with status
    {
        if (IsDone())// why is it having a stroke here
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
        _name = name;// what is wrong with this
                     // update it was a void
    }

    public string GetDescription()
    {
        // Console.WriteLine("What is a short description of the goal? ");
        //  string descriptionInput = Console.ReadLine();
        return _description;
    }

    public void SetDescription(string description)// whyyy is its  not working
    {
        _description = description;
    }
    public int Getpoints()
    {
        // Console.Write("How many points do you want with this goal? ")
        // int pointsInput = readline();
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

    public abstract void RunGoal();

    public void ListGoal()
    {

    }
    
    
}