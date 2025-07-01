using System;
public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    public Goal()
    {
        _name = "";
        _description = "";
        _points = ; // fix this

    }
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;

    }

    public void RecordedGoal()//handles completed goal
    {

    }

    public void IsDone()// checks if goal is done or not
    {

    }

    public virtual string DisplayGoalDetails()//displays goal details with status
    {

    }
    public virtual int GetPoints()//gets point value of goal
    {

    }

    public virtual string SaveGoalInfo()//formats goal data for saving


    {
        
    }

}