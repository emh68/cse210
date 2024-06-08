public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse, int endVerse = -1)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse == -1 ? verse : endVerse;
    }

    public string book
    {
        get { return _book; }
        set { _book = value; }
    }

    public int chapter
    {
        get { return _chapter; }
        set
        {
            if (value > 0) _chapter = value;
            else throw new ArgumentException("Chapter must be greater than 0.");
        }
    }

    public int verse
    {
        get { return _verse; }
        set
        {
            if (value > 0) _verse = value;
            else throw new ArgumentException("Verse must be greater than 0.");
        }
    }

    public int EndVerse
    {
        get { return _endVerse; }
        set
        {
            if (value == -1 || value >= _verse) _endVerse = value;
            else throw new ArgumentException("End verse must not be the same as starting verse.");
        }
    }

    public string GetDisplayText()
    {
        if (_endVerse > _verse)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }

    }
}