using System;
using System.Collections.Generic;
public class Entry
{
    private string _date;
    private string _entry;
    private string _prompt;

    public Entry()
    {
        _date = "";
        _entry = "";
        _prompt = ""; 
    }
    public Entry(string date, string entry, string prompt)
    {
        _date = date;
        _entry = entry;
        _prompt = prompt;
    }
    public void RequestEntry()
    {
        GetRandomPrompt();
        Console.WriteLine("Write your entry here:");
        _entry = Console.ReadLine();
    }
    public void GetRandomPrompt()
    {
        List<string> prompts = new List<string>(){"Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?","What did I learn about myself today?", "Who did I serve or help today, and how did it feel?", "What moment today am I most grateful for?", "Did I feel inspired today? When and why?", "What was a challenge I faced today, and how did I respond?", "What act of kindness did I witness or receive today?", "Where did I feel peace or calm today?", "How did I show love to someone today?", "What did I do today that brought me closer to my goals or values?", "Was there a moment today when I felt God’s guidance or comfort?", "Did I take time to really listen to someone today?", "What did I avoid today that I should have faced?", "What beauty did I notice today, in people or the world around me?", "How did I grow spiritually or emotionally today?", "What was one decision I made today that I feel good about?"
    };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        _prompt = prompts[index];
        _date = DateTime.Now.ToString();
        Console.WriteLine($"\n{_date} -The Prompt is:\n {_prompt}");
    }
    public override string ToString()
    {
        string outputstring = "";
        outputstring = $"{_date} {_prompt} {_entry}";
        return outputstring;
    }
    public string GetEntryForFile()
    // journal finding entries
    {
        string outputString = $"{_date}#{_prompt}#{_entry}";
        return outputString;
    }
    public void UpdateEntry(string newEntryText)
{
    _entry = newEntryText;
}
public string ShortPreview()
{
    return $"{_date} - {_prompt.Substring(0, Math.Min(_prompt.Length, 25))}";
}
}