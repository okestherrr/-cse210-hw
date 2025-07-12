using System;
public class EternalGoal : BaseGoal
{
    private int _numberOfCompletion;

        public EternalGoal(string name, string description, int point, int completions) : base(name, description, point, "Eternal")
    {
        _numberOfCompletion = 0;// is this correct?
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
        return $"[∞] {_name} ({_description}) — Completed {_numberOfCompletion} times";
    }
    public override string StringForGoalFile()
    {
        return $"EG#{_numberOfCompletion}#{_name}#{_description}#{_points}";
    }
      public override int RecordEvent()
    {
      _numberOfCompletion++;
        return _points;
    }

}