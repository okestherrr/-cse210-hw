using System;

public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _numberOfCompletion;
    private int _maxGoal;

    public ChecklistGoal(int bonus, int numberOfCompletion, int maxGoal) : base("")// fix
    {
        _bonus = bonus;
        _numberOfCompletion = numberOfCompletion;
        _maxGoal = maxGoal;
    }

    public override void RecordedEvent()//awards points and bonus if completed
    {

    }

    public bool IsDone()// return true if count is more than or is the target amount
    {

    }

    public override string FormatedDisplay()//shows "[ ] Name - Completed x/y"
    {

    }

    public override string CountBonus()// includes count and bonuses in the formatedDisplay
    {

    }




}