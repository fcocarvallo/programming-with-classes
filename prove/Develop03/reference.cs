using System;
class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
     _book = book;
     _chapter = chapter;
     _startVerse = startVerse;
     _endVerse = endVerse;   
    }

    public Reference(string book, string chapter, string startVerse)
    {
     _book = book;
     _chapter = chapter;
     _startVerse = startVerse;
     _endVerse = "";   
    }

    private string ComposeReference()
    {
        string text;
        if (_endVerse == "")
        {
            text = $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            text = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        return text;
    }

    public void DisplayReference()
    {
        Console.WriteLine(ComposeReference());
    }
   

}