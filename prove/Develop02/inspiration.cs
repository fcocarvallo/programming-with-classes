using System.Net;

class Inspire
{

    public string[] _quotes = new string[]
    {
    // President Spencer W. Kimball
    "\"Every person should keep a journal and every person can keep a journal. It should be an enlightening one and should bring great blessings and happiness to the families. If there is anyone here who isn't doing so, will you repent today and change?\" - President Spencer W. Kimball",
    
    // President Henry B. Eyring
    "\"I wrote down a few lines every day for years. I never missed a day no matter how tired I was or how early I would have to start the next day. Before I would write, I would ponder this question: 'Have I seen the hand of God reaching out to touch us or our children or our family today?'\" - President Henry B. Eyring",
    
    // Elder Richard G. Scott
    "\"Knowledge carefully recorded is knowledge available in time of need. Spiritually sensitive information should be kept in a sacred place that communicates to the Lord how you treasure it. This practice enhances the likelihood of your receiving further light.\" - Elder Richard G. Scott",
    
    // President Gordon B. Hinckley
    "\"I urge you to write in your journal. Your journal should contain your true self, your thoughts, your feelings, your experiences. It will be a great source of satisfaction to you in the years that lie ahead.\" - President Gordon B. Hinckley",
    
    // Elder M. Russell Ballard
    "\"When I was a boy, I always wondered why people bothered to make a record of their lives. I have learned, however, that those who keep a book of remembrance are more likely to keep the Lord in remembrance in their daily lives.\" - Elder M. Russell Ballard",
    
    // Sister Wendy Watson Nelson
    "\"Writing can help us to remember what the Lord has taught us. It can help us to recognize His hand in our lives. And it can help us to hear His voice.\" - Sister Wendy Watson Nelson",
    
    // President John Taylor
    "\"I have endeavored to keep a journal of my life, and I have written a great many things. Why? Because they are of value.\" - President John Taylor",
    
    // Elder M. Russell Ballard
    "\"What an inspiring thing it is to read of the faith and valor of our forebears! We must provide for the future by keeping our own records now.\" - Elder M. Russell Ballard",
    
    // President Brigham Young
    "\"If you have a history of your lives, when you are where you can look upon the path you have passed, you will then begin to know yourselves.\" - President Brigham Young",
    
    // Elder David A. Bednar
    "\"The spiritual practice of journaling can help us to 'remember how merciful the Lord hath been' and to hear His voice more clearly.\" - Elder David A. Bednar"
    };


    public void GetQuote()
    {

        string ready;

        do
        {

            Random random = new Random();
            int number = random.Next(0, 9);
            string selectedQuote = _quotes[number];
            Console.WriteLine(selectedQuote);

            Console.WriteLine("\nAre you ready to write on your journal Now?");
            Console.WriteLine("'no' to keep getting inspire, 'yes' to go to the Menu:");
            ready = Console.ReadLine()!;


        } while (ready != "yes");



    }
}