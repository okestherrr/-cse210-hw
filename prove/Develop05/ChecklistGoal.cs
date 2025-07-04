using System;

public class ChecklistGoal : BaseGoal
{
    private int _bonus;
    private int _numberOfCompletion;
    private int _maxGoal;

    public ChecklistGoal(string name, string description, int points, bool status, int bonus, int completions, int max) : base(name, description, points, status, bonus, completions, max)// fix
    {
        _bonus = bonus;
        _numberOfCompletion = completions;
        _maxGoal = max;
    }

    // public override int RecordEvent()//awards points and bonus if completed
    // {
    //     return 1;//fix this 
    // }

    public override string CountBonus()// includes count and bonuses in the formatedDisplay
    {

    }
    public override void PopulateGoal()
    {

    }
     public override string StringforGoalFile()
    {
        return $"CLG#" + base.StringforGoalFile();
    }
}