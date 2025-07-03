using System;
public class EternalGoal : BaseGoal
{
    private int _numberOfCompletion;
    
    public EternalGoal()
    {
        _numberOfCompletion = 0;// is this correct
    }
    public EternalGoal(string name, string description, int points, bool status, int completions) : base()
    {
        _numberOfCompletion = completions;
    }

    public override void PopulateGoal()
    {

    }
    public override int RecordEvent()
    {
        return 1; // fix
    }
    public override string GetGoalType()
    {
        return "";
    }
    
    public override string ToString()// help with this
    {
        return "";
    }

    

    public override string SendToFile()///isnt this suppost to go to file?
    {
        string OutputGoal = $"{ } #{_name}#{desciption}";
        return OutputGoal;
    }

}