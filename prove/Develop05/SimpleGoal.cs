using System;

public class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool status, string goalType) : base(name, description, points, status, goalType)
    {
    }

    // public override int RecordEvent()
    // {
    //     return 1; //fix this 
    // }

    public override void PopulateGoal()
    {
    }
     public override string StringforGoalFile()
    {
        return $"SG#" + base.StringforGoalFile();
    }
   
}