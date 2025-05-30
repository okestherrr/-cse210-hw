public class Reference
{
    private string _book;
    private int _chapter;
    private int _beginverse;
    private int _endverse;

    public Reference(string book, int chapter, int beginverse)// to get single verses
    {
        _book = book;
        _chapter = chapter;
        _beginverse = beginverse;
        _endverse = -1;
    }
    public Reference(string book, int chapter, int beginverse, int endverse)// to get single verses
    
    {
        _book = book;
        _chapter = chapter;
        _beginverse = beginverse;
        _endverse = endverse;    // this is 2nd constructor to reference multiple verse
    }
    public string GetDisplayText()
    {
        if (_endverse == -1)
        {
            return ($"{_book} {_chapter}:{_beginverse}");
        }
        return ($"{_book} {_chapter}:{_beginverse}{_endverse}");

    }

}
