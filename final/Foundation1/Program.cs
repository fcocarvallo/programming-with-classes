using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        List<Video> myVideos = new List<Video>();

        // Billie Jean - Michael Jackson
        Video billieJean = new Video();
        billieJean._title = "Billy Jean";
        billieJean._author = "Michael Jackson";
        billieJean._length = 294;
        billieJean._views = 4958774;
            //Comment #1
            Comment billie1 = new Comment();
            billie1._person = "Nick Anderson";
            billie1._commentText = "I loved this video! Michael Jackson was the king.";
            
            //Comment #2
            Comment billie2 = new Comment();
            billie2._person = "Nicole Smith";
            billie2._commentText = "It is impressive how he danced. You can't find that talent these days...";
            //Comment #3
            Comment billie3 = new Comment();
            billie3._person = "Albert Nielsen";
            billie3._commentText = "So many memories come to my mind. I remember when I was a child... I used to imitate MJ while watching his videos";

                //Adds comments
                billieJean._myComments.Add(billie1);
                billieJean._myComments.Add(billie2);
                billieJean._myComments.Add(billie3);


        // Welcome to the jungle - Guns N' Roses
        Video welcomeToJungle = new Video();
        welcomeToJungle._title = "Welcome to the Jungle";
        welcomeToJungle._author = "Guns N' Roses";
        welcomeToJungle._length = 274;
        welcomeToJungle._views = 3434837;
            //Comment #1
            Comment welcome1 = new Comment();
            welcome1._person = "Luke Christensen";
            welcome1._commentText = "This is the best song ever! I whish I could play the guitar like that!.";
            
            //Comment #2
            Comment welcome2 = new Comment();
            welcome2._person = "George Wakefield";
            welcome2._commentText = "I remember when I played this song with my school band. I really miss those days.";
            //Comment #3
            Comment welcome3 = new Comment();
            welcome3._person = "John Edwars";
            welcome3._commentText = "WoooOw! I love the rithm of this song. It is the best!";

                //Adds comments
                welcomeToJungle._myComments.Add(welcome1);
                welcomeToJungle._myComments.Add(welcome2);
                welcomeToJungle._myComments.Add(welcome3);

        // Back in Black - AC/DC
        Video backInBlack = new Video();
        backInBlack._title = "Back in Black";
        backInBlack._author = "AC/DC";
        backInBlack._length = 255;
        backInBlack._views = 2938475;
                        //Comment #1
            Comment back1 = new Comment();
            back1._person = "Scott Erickson";
            back1._commentText = "That was my favorite song when I was in college. Well, it is still the best song of the world!";
            
            //Comment #2
            Comment back2 = new Comment();
            back2._person = "Anne Johnson";
            back2._commentText = "I really love AC/DC! I went to the show when they released this album. It was fantastic!";
            //Comment #3
            Comment back3 = new Comment();
            back3._person = "Andrew Hamilton";
            back3._commentText = "No matter how old I am, I enjoy this song as much as I was 20!";

                //Adds comments
                backInBlack._myComments.Add(back1);
                backInBlack._myComments.Add(back2);
                backInBlack._myComments.Add(back3);


        //Add videos to the list
        myVideos.Add(billieJean);
        myVideos.Add(welcomeToJungle);
        myVideos.Add(backInBlack);
        
        //Diplay video information and comments
        foreach(Video video in myVideos)
        {
            video.SongInfo();
            video.DisplayComments();
        }




    }
}