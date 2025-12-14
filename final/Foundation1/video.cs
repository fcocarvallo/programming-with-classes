using System.IO.Compression;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public int _views;

    public List<Comment> _myComments = new List<Comment>();

    public int CommentsNumber()
    {
        int i = 0;
        foreach(Comment comment in _myComments)
        {
            i++;
        }
        return i;
    }

    public void SongInfo()
    {   
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        Console.WriteLine($" Title: {_title}\n Artist: {_author}\n Duration: {_length} seconds\n Views: {_views.ToString("N0")}");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
    }

    public void DisplayComments()
    {
        Console.WriteLine($"Comments({CommentsNumber()})\n");
        foreach(Comment comment in _myComments)
        {
            comment.CommentInfo();

        }
    }


}

