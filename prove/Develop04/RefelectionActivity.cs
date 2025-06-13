class ReflectionActivity : BaseActivity
{
    private List<FlaggedString> _prompts = new List<FlaggedString>();
    private List<FlaggedString> _questions = new List<FlaggedString>();
    {
        //constructor here, but how do i use a list in a const
    }// use base class here
    public ReflectionActivity(List<FlaggedString> prompts) : BaseActivity(string name, string description, int seconds) 
    {
        _prompts = prompts;
    }
    // public void Addprompts(FlaggedString prompt)
    // {
    // _prompts.Add(prompt);
    // }
    public void RunActivity()
    {
        
    }
    public void reflextion()
    {

    }
  

}