using System.IO.Compression;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _myComments = new List<Comment>();

    public string CommentsNumber(List<Comment> myComments)
    {
        int i = 0;
        foreach(Comment comment in myComments)
        {
            i++;
        }
        return i.ToString();
    }

    public void SongInfo()
    {   
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        Console.WriteLine($" Title: {_title}\n Artist: {_author}\n Duration: {_length} seconds");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
    }

    public void DisplayComments()
    {
        Console.WriteLine($"Comments({CommentsNumber(_myComments)})\n");
        foreach(Comment comment in _myComments)
        {
            comment.commentInfo();

        }
    }


}

