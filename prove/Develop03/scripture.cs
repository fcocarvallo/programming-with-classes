using System;
class Scripture
{
    private string _reference;
    private string _scripture;
    private List<Word> _wordsList;

    public Scripture(string scripture)
    {
        _scripture = scripture;
        _wordsList = new List<Word>();

        string[] words = _scripture.Split(" ");

        foreach (string word in words)
        {
            Word w = new Word(word);
            _wordsList.Add(w);
        }

    }

    public void ShowText()
    {
        Console.WriteLine(_scripture);
    }

    public void ShowList()
    {
        foreach (Word w in _wordsList)
        {
            Console.Write(w.GetWordString() + " ");
        }
        Console.WriteLine();
    }

    public void ChangeStatus()
    {   
        int ratio = 100;
        Random random = new Random();
        
        foreach (Word word in _wordsList)
        {

            if (word.IsHidden() == false)
            {
                int result = random.Next(0,ratio);
                int decision;

                if (result <= 35)
                {
                    decision = 1;
                }
                else
                {
                    decision = 0;
                } 

                if (decision == 1)
                {
                    word.HideWord();
                }
            }
            
        } 

    }

    public void ForceHide()
    {
        foreach (Word word in _wordsList){
            word.HideWord();
        }
    }

}