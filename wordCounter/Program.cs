using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        WordCounter wordCounter = new WordCounter("whis is the new text string tha will text to see if it works lets see if this text works.");
        wordCounter.DisplayWord();

        int count = wordCounter.CountSingleWord("text");
        Console.WriteLine($"The word: text, was found: {count} times.");
    }
}