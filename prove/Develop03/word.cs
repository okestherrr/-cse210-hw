public class Word
{
    private string _word;
    private string _text;
    private bool _WordisHidden;

    public Word(string word)
    {
        _word = word;
        _WordisHidden = false;
    }

    public Word(string text, bool WordisHidden)
    {
        _text = text;
        _WordisHidden = WordisHidden;
    }

    public string Hide()
    {
        if (_WordisHidden)
        {
            string hiddenword = GetBlankText();
            return hiddenword;
            //return GetBlankText();
        }

        return _text;
    }

    public bool WordIsHidden()
    {
        return _WordisHidden;
    }

    private string GetBlankText()
    {
        string hiddenword = "";
        foreach (var letter in _text)
        {
            hiddenword += "-";
        }
        return hiddenword;
    }
}
