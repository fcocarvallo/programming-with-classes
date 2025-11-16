using System;
class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    private string LocalGetWordString()
    {
        if (_isHidden)
        {
            string newString = "";
            foreach(char c in _word)
            {
                newString += "_";
            }
            return newString;
        }
        else
        {
            return _word;
        }
    }

    public void DisplayWord()
    {
        Console.WriteLine(LocalGetWordString());
    }

    public string GetWordString()
    {
        return LocalGetWordString();
    }



}