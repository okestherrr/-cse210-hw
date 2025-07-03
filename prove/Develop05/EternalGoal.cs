using System;
using System.Net;
public class EternalGoal : BaseGoal
{
    private int _numberOfCompletion;
    public void EternalGoal(string name,string  description, int points, bool status,int completions) : base()
    {
        
    }

    public override int RecordEvent()
    {
        return 1; // fix
    }
    public override void RunGoal()
    {

    }
    public override string ToString()// help with this
    {
        return "";
    }
    public override string GetGoalType()
    {
        return "";
    }
    public override string ListGoal()
    {
        //write to file
    }

    // public override bool IsDone()
    // {
    //     return _isDone;
    // }

    // public override string DisplayEmpty()
    // {

    // }

    // public override string SaveGoalInfo()
    // {

    // }

}