public class Word
{
    private string _word;
    private bool _WordisHidden;

    public Word(string word)
    {
        _word = word;
        _WordisHidden = false;
    }

    public string GetDisplayText() // previously GetWord
    {
        if (_WordisHidden)
        {
            return GetBlankText();
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
        return new string('_', _word.Length);
    }
}
