class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {   
    }
    public override void RunActivity()
    {
       for (int i = 0; i < _duration / 6; i++)
        {
            Console.Write("Breathe in... ");
            RunCountDown(3);
            Console.Write("Now breathe out... ");
            RunCountDown(3);
            Console.WriteLine();
        }
    }   
}