using System;
using System.Diagnostics.Contracts;
public class SimpleGoal
{
    private bool _isDone;

    public SimpleGoal(bool isDone) : base()
    {
        _isDone = isDone;
    }

    public override void RecoredEvent()
    {

    }

    public override bool IsDone()//returns if it is Done to base
    {

    }
    public override string DisplayX()// puts X if it is complete
    {

    }
    public override string SaveGoalInfo()// Adds _isDone to save it
    {

    }

}