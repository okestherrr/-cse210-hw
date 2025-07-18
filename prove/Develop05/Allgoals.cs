using System.Threading.Channels;

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
    public void SendToFile(string _filename)///isnt this suppost to go to file?
    {
    using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(_totalScore);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.StringForGoalFile());// write this to a file // helpppp go to past project for this 
            }
        }

    }
    public void ReadFromFile(string _filename)
     {
    //     if (!File.Exists(_filename))
    //     {
    //         Console.WriteLine("File not available");
    //         return;
    //     }
        string[] parts = File.ReadAllLines(_filename);
        foreach (string part in parts)
        {
            string[] lines = part.Split("#");
            if (lines.Length == 1)
            {
                _totalScore = int.Parse(lines[0]);
                
            }
            else 
            {
                  string goaltype = lines[0];
                    string name = lines[1];
                    string description = lines[2];
                    int points = int.Parse(lines[3]);
                    bool status = bool.Parse(lines[4]);
                
                if (goaltype == "CLG")
                {
                  
                    int current = int.Parse(lines[5]);
                    int max = int.Parse(lines[6]);
                    int bonus = int.Parse(lines[7]);
                    ChecklistGoal newGoal = new ChecklistGoal(name,description,points,status,current, max, bonus);
                    AddGoals(newGoal);
                }
                else if (goaltype == "SG")
                {
                    SimpleGoal newGoal = new SimpleGoal(name,description,points,status);
                    AddGoals(newGoal);
                }
                else if (goaltype == "EG")
                {
                     int completion = int.Parse(lines[6]);
                    EternalGoal newGoal = new EternalGoal(name,description,points, status, completion);
                    AddGoals(newGoal);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }

    }
    public void DisplayGoals()
    {
        Console.WriteLine("The Goals are: ");
        int index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.ToString()}");
            index++;
        }

    }
    public void DisplayScore()
    {
        Console.WriteLine($" You have {_totalScore} points.");
    }
    // private void GetFileName()// fix this and where do iput this
    // {
    //     Console.WriteLine("What file do you want to save it to? ");
    //     _filename = Console.ReadLine();
    // }
    public void CompleteGoal(int index)
    {
       Console.WriteLine(_goals[index -1].RecordEvent());
    }
    
}