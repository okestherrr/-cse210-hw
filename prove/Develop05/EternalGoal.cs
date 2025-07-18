using System;
public class EternalGoal : BaseGoal
{
    private int _numberOfCompletion;

        public EternalGoal(string name, string description, int point, bool status, int completion) : base(name, description, point, status, "Eternal")
    {
        
        _numberOfCompletion = completion;// is this correct?
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
        return $"[∞] {_name} ({_description}) —- Currently completed: {_numberOfCompletion}";
    }
    public override string StringForGoalFile()
    {
        return $"EG#{_name}#{_description}#{_points}#{_status}#{_numberOfCompletion}#";
    }
      public override int RecordEvent()
    {
      _numberOfCompletion++;
        return _points;
    }

}