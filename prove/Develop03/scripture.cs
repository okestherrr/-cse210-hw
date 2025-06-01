public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();
    // private List<Word> listOfWordsOfVerses = new List<Word>() {"He saved us, not because of righteous things we had done, but because of his mercy.", "But God demonstrates his own love for us in this: While we were still sinners, Christ died for us};// verses here", "For it is by grace you have been saved, through faith—and this is not from yourselves, it is the gift of God—not by works, so that no one can boast", "This is how God showed his love among us: He sent his one and only Son into the world that we might live through him." };
    // private List<string> _words = new List<string>() {"Proverbs 3:5-6", "John 3:16", "Romans 5:8", "Ephesians 2:8–9", "1 John 4:9–10"};


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
        int hidden = 0;
        List<int> unhiddenIndexedWords = new List<int>();
        // _words[count].HideWord();//test
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].WordIsHidden())
                unhiddenIndexedWords.Add(i);//organizing what words are hidden vs not

        }
        while (hidden < count && unhiddenIndexedWords.Count > 0)
        {
            int randomWordIndex = _random.Next(unhiddenIndexedWords.Count);
            int wordIndex = unhiddenIndexedWords[randomWordIndex];
            _words[wordIndex].HideWord();
            unhiddenIndexedWords.RemoveAt(randomWordIndex);
            hidden++;
        }
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
public string DisplayHiddenText()
{
    string display = _reference.GetDisplayText() + " - ";
    foreach (Word word in _words)
    {
        display += word.GetDisplayText() + " ";
    }
    return display.Trim();
}
    public Reference GetReference()
    {
        return _reference;
    }
}