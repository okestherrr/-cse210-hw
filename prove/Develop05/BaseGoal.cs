using System;
using System.ComponentModel;
using System.Numerics;
public abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private string _filename;
    private int _totalScore;
    private bool _status;
    private string _goalType;
    private int _totalScore = 0;
    List<BaseGoal> _goals = new List<BaseGoal>();//am i doing this right
   
    
    public BaseGoal(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status;
        _goalType = goalType;

    }

    public abstract int RecordGoal();//handles completed goal- is abstract so doesnt need any parameters
    

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
    public override string ToString()// help with this cuz i do be struggling lol
    {
        Console.WriteLine($" {MarkDone} {_description}");
    }

    public abstract string RunGoal();

    public void ListGoal()
    {
        Console.WriteLine("The Goals are: ");
        int index = 1;
        foreach (BaseGoal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.ToString()}");
            index++;
        }
    }
    public void AddGoals(BaseGoal goal)
    {
        _goals.Add(goal);
    }
    public void LoadGoals()
    {

    }
    public void SaveGoals()
    {

    }
    public void DisplayGoals()
    {

    }
    public void DisplayScore()
    {
        Console.Writeline($" You have {_totalScore} points.");
    }
    private void GetFileName(string prompt)
    {

    }
}