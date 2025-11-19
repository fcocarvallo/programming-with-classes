public class Math: Assignment
{
    private string _textSection;
    private string _problems;



    public Math(string studentName, string topic, string textSection, string problems) : base(studentName, topic)
    {
        _textSection = textSection;
        _problems = problems;

    }

    public string GetHomeworkList() 
    {
        return $"{GetSummary()} - Section {_textSection} Problems {_problems}";
    }
};