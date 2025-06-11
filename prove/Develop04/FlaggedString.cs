

class FlaggedString
{
    private string _prompt;
    private bool _hasBeenUsed;
    public FlaggedString(string prompt, bool hidden)
    {
        _prompt = prompt;
        _hasBeenUsed = hidden;//correct this if wrong
    }
    public string GetPrompt()
    {
        return _prompt; //something;list of prompts??
    }
    public void SetHasBeenUsed(bool used)// if it shows up as used
    {
        _hasBeenUsed = used;
    }
    public bool GetHasBeenUsed()// returns if it has been used or not
    {
        return _hasBeenUsed; 
    }

}