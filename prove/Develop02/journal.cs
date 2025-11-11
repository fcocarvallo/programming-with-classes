using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Journal
{

    public List<string> _entries = new List<string>();


    public void AddEntry(string entry)
    {

        _entries.Add(entry);

    }


    public void ShowEntries()
    {

        foreach (string entry in _entries)
        {
            string[] parts = entry.Split("~");
            string date = parts[0];
            string prompt = parts[1];
            string answer = parts[2];
            Console.WriteLine($"{date}\n{prompt}\n{answer}\n");
        }



    }

    public void SaveToFile()
    {
        string userFileName;
        Console.WriteLine("How do you want to call your file?");
        userFileName = Console.ReadLine()!;

        string filename = userFileName;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            foreach (string line in _entries)
            {
                outputFile.WriteLine(line);
            }


        }

        Console.WriteLine("File saved successfully!\n");

    }

    public void LoadFromFile()
    {

        string fileLoadFrom;
        Console.WriteLine("Write the name of the file you want to load: ");
        fileLoadFrom = Console.ReadLine()!;

        string filename = fileLoadFrom;

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {

            _entries.Add(line);


        }

        Console.WriteLine("File loaded successfully!\n");




    }
    

        public void ClearJournal()
    {
        _entries.Clear();

    }


}