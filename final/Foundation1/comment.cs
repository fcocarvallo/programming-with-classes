public class Comment
{
 public string _person;   
 public string _commentText;

 public void commentInfo()
    {
        Console.WriteLine($"{_person}:\n   -{_commentText}");
        Console.WriteLine();
    }



}