public abstract class BaseActivity
{
    private string _name;
    private string _description;
    protected int _duration;

    //private int _buffer;
    private DateTime _endTime; 
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;

    }
    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");

    }
    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }
    public void DisplayEnding()
    {
        Console.WriteLine($"\nGood job!\n");
        Console.WriteLine($"You finished the {_name} activity within {_duration} seconds.");
        DisplaySpinner(3);
       
    }
    public void RunCountDown(int seconds)
    {
        for (int t = seconds; t > 0; t--)
        {
            Console.Write(t);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public void DisplaySpinner(int seconds)
    {
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");

    }
    public void EndtimeCalulation()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
        //time would start w now. when the duration ends
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void Run()// attempting to do polymormphism w help from lab friends
    {
        Console.Clear();
        DisplayGreeting();
        DisplayDescription();
        Console.Write("How long do you want this activity to be (in seconds)? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("\nPlease get ready...");
        RunCountDown(3);
        Console.Write("\b \b");
        RunActivity();
        DisplayEnding();
        //Console.Write($"thanks for coming to {_name}"); // fix this w more details
    }
    public abstract void RunActivity();
}