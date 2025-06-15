public class ListingActivity : BaseActivity
{
    private Random _random = new Random();
private List<string> _prompts = new List<string>() {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?" };// shows starting message and random prompt, give countdown, count responces, show ending message, put as many answers
  
    public ListingActivity() : base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
     public override void RunActivity()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine("\n" + prompt);
        Console.WriteLine("You may begin listing items after the countdown...");
        RunCountDown(3);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items. Well done!");
    }
}