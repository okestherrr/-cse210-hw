using System;

public class SimpleGoal : BaseGoal
{
    // public SimpleGoal(name, description, points, status)
    // {

    // }

    private bool _isDone;

    public SimpleGoal(bool isDone) : base()
    {
        _isDone = isDone;
    }

    public override void RecordEvent()
    {

    }

    public override void RunGoal()
    {

    }
    // public override string DisplayX()// puts X if it is complete
    // {

    // }
    // public override bool IsDone()//returns if it is Done to base
    // {
    //     return _isDone;
    // }
    
    // public override string SaveGoalInfo()// Adds _isDone to save it
    // {

    // }
}