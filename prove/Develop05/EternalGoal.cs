using System;
public class EternalGoal : BaseGoal
{
    private int _numberOfCompletion;

    public EternalGoal()
    {
        _numberOfCompletion = 0;// is this correct?
    }
    public EternalGoal(string name, string description, int point, int completions) : base(name, description,point, status completions)
    {
        _numberOfCompletion = completions;
    }

    public override void PopulateGoal()//loadgoal
    {

    }
    public override string GetGoalType()
    {
        return "";
    }

    public override string ToString()
    {
        string GoalOutPut = "";
        GoalOutPut = $"{_status} {name} {desciption}";//help with this
        return GoalOutPut;
    }
    public override string ListFile()///isnt this suppost to go to file?
    {

    }
    public override string StringforGoalFile()
    {
        return $"EG#" + base.StringforGoalFile();
    }
    // public override int RecordEvent()
    // {
    //     return 1; // fix
    // }

}