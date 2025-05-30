public class Word
{
    private string _word;
    private bool _WordisHidden;

    public Word(string word)
    {
        _word = word;
        _WordisHidden = false;
    }

    public string GetWord()
    {
        if (_WordisHidden)
        {
            string hiddenword = GetBlankText();
            return hiddenword;
        }

        return _word;
    }

    public void HideWord()
    {
        _WordisHidden = true;

    }


    public bool WordIsHidden()
    {
        return _WordisHidden;
    }

    private string GetBlankText()
    {
        string hiddenword = "";
        foreach (var letter in _word)
        {
            hiddenword += "_";
        }
        return hiddenword;
    }
}
