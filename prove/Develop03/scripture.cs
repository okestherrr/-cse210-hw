public class Scripture
{
    private Reference _reference;
    // private List<Word> listOfWordsOfVerses = new List<Word>() {"He saved us, not because of righteous things we had done, but because of his mercy.", "But God demonstrates his own love for us in this: While we were still sinners, Christ died for us};// verses here", "For it is by grace you have been saved, through faith—and this is not from yourselves, it is the gift of God—not by works, so that no one can boast", "This is how God showed his love among us: He sent his one and only Son into the world that we might live through him." };
    // private List<string> _words = new List<string>() {"Proverbs 3:5-6", "John 3:16", "Romans 5:8", "Ephesians 2:8–9", "1 John 4:9–10"};
    private string _scripture;

    private List<Word> _words;

    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        _scripture = scripture;

        // string[] scripture = _words[reference].Split("/");
        // string[] verseText = scripture[1].Split(" ");

        string[] words = _scripture.Split(" ");

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int count, Random random)
    {
        List<int> unhiddenIndexedWords = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
             if (!_words[i].WordIsHidden())
            {
                 unhiddenIndexedWords.Add(i);//organizing what words are hidden vs not
            }
        }
        // has 3 statements here
    }

//     public bool AllHiddenWordsCheck()
//     {
        
//     }

//     public string DisplayHIddenText()
//     {
//         foreach GetBlankText 
//     }
//     public reference GetReference()// how do I make it return a reference 
}