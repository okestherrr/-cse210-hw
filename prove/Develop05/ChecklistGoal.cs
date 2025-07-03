using System;

public class ChecklistGoal : BaseGoal
{
    private int _bonus;
    private int _numberOfCompletion;
    private int _maxGoal;

    public ChecklistGoal(string name, string description, int poinds, bool status, int bonus, int completions, int max, int bonus) : base("")// fix
    {
        _bonus = bonus;
        _numberOfCompletion = completions;
        _maxGoal = max;
    }

    public override int RecordEvent()//awards points and bonus if completed
    {
        return 1;//fix this 
    }

    public override string CountBonus()// includes count and bonuses in the formatedDisplay
    {

    }
    public override void PopulateGoal()
    {

    }




}