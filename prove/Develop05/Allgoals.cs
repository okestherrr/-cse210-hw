public class Allgoals
{
    private int _totalScore;
    private string _filename;

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
    public void SendToFile()///isnt this suppost to go to file?
    {
        foreach (BaseGoal goal in _goals)
        {
            Console.WriteLine(goal.StringForGoalFile());// write this to a file // helpppp go to past project for this 
        }
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
    private void GetFileName()// fix this and where do iput this
    {
        Console.WriteLine("What file do you want to save it to? ");
        _filename = Console.ReadLine();
    } 
}