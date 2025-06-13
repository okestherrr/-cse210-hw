public class ListingActivity : BaseActivity
{// shows starting message and random prompt, give countdown, count responces, show ending message, put as many answers
    private List<FlaggedString> _prompts;
    {

    }
    public ListingActivity(string name, string description, int seconds, DateTime endtime) : base( name, description, seconds, endtime)
    {

    }
    public void RunActivity(string _duration)
    {
        (StartTime())// is this a dup
    }
    public void SetPrompts()
    {
        List<string> _prompts = new List<string>(){"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    }
    public void ResetPromptsUsage()
    {
        while _prompts 
    }
}