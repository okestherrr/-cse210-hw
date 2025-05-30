public class Scripture
{
    private Reference _reference;
    // private List<Word> listOfWordsOfVerses = new List<Word>() {"He saved us, not because of righteous things we had done, but because of his mercy.", "But God demonstrates his own love for us in this: While we were still sinners, Christ died for us};// verses here", "For it is by grace you have been saved, through faith—and this is not from yourselves, it is the gift of God—not by works, so that no one can boast", "This is how God showed his love among us: He sent his one and only Son into the world that we might live through him." };
    // private List<string> _words = new List<string>() {"Proverbs 3:5-6", "John 3:16", "Romans 5:8", "Ephesians 2:8–9", "1 John 4:9–10"};
    private List<Word> _words;

    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = scripture.Split(' ');

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }

    }
    public void HideRandomWords(int count)
    {
        _words[count].HideWord();//test

        //if word is hidden then 
        // List<int> unhiddenIndexedWords = new List<int>();
        // for (int i = 0; i < _words.Count; i++)
        // {
        //      if (!_words[i].WordIsHidden())
        //     {
        //          unhiddenIndexedWords.Add(i);//organizing what words are hidden vs not
        //     }
        // }
    }

    public bool AllHiddenWordsCheck() // are all hidden
    {
        foreach (Word word in _words)
        {
            if (!word.WordIsHidden())
            {
                return false;
            }

        }
        return true;   
    }

    public void DisplayHiddenText()
    {
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }
}