
using System;

class Program
{
    
    static void Main(string[] args)
    {
        int selectedOption = 0;
        Journal myJournal = new Journal();
        Inspire inspiration = new Inspire();

        do
        {


            Entry mymenu = new Entry();
            mymenu.ShowMenu();
            selectedOption = mymenu.UserSelection();

            if (selectedOption == 1)
            {
                // string entry = "";


                string entry = mymenu.ComposeEntry();
                myJournal.AddEntry(entry);

            }
            else if (selectedOption == 2)
            {
                myJournal.ShowEntries();
            }
            else if (selectedOption == 3)
            {

                myJournal.ClearJournal();
                myJournal.LoadFromFile();


            }
            else if (selectedOption == 4)
            {

                myJournal.SaveToFile(); 



            }
            else if (selectedOption == 5)
            {
                inspiration.GetQuote();
            }
            else if (selectedOption == 6)
            {
                Console.WriteLine("Thank you for taking the time to write on your journal!");
            }


        } while (selectedOption != 6);

    }


}