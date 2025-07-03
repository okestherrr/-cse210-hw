public class Allgoals
{
     private int _totalScore;
    private List<BaseGoal> _goals;
    public Allgoals()
    {
        _totalScore = 0;
        _goals = new List<BaseGoal>();
    }

    public void AddGoals(BaseGoal goal)
    {
        _goals.Add(goal);
    }
    public void LoadGoals()
    {
        
    }
    public void SaveGoals()
    {

    }
    public void DisplayGoals()
    {
        Console.WriteLine("The Goals are: ");
        int index = 1;
        foreach (BaseGoal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.ToString()}");
            index++;
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($" You have {_totalScore} points.");
    }
    private void GetFileName(string prompt)
    {

    }
}