using System;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;

class Library
{
    
private string[] _scriptures = 
{
    "1 Nephi~3:7|And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
    "2 Nephi~31:20|Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.",
    "Mosiah~2:17|And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.",
    "Alma~32:21|And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.",
    "Alma~34:32-34|For behold, this life is the time for men to prepare to meet God; yea, behold the day of this life is the day for men to perform their labors. And now, as I said unto you before, as ye have had so many witnesses, therefore, I beseech of you that ye do not procrastinate the day of your repentance until the end; for after this day of life, which is given us to prepare for eternity, behold, if we do not improve our time while in this life, then cometh the night of darkness wherein there can be no labor performed. Ye cannot say, when ye are brought to that awful crisis, that I will repent, that I will return to my God. Nay, ye cannot say this; for that same spirit which doth possess your bodies at the time that ye go out of this life, that same spirit will have power to possess your body in that eternal world.",
    "3 Nephi~11:10-11|Behold, I am Jesus Christ, whom the prophets testified shall come into the world. And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.",
    "Ether~12:6|And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.",
    "Moroni~10:4-5|And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.",
    "2 Nephi~28:30|For behold, thus saith the Lord God: I will give unto the children of men line upon line, precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts, and lend an ear unto my counsel, for they shall learn wisdom; for unto him that receiveth I will give more; and from them that shall say, We have enough, from them shall be taken away even that which they have."
};

private string[] _selectedScripture; 

    private string GetScripture()
    {
        Random random = new Random();
        int n = random.Next(0,6);
        string text = _scriptures[n];
        return text; 
    }

    private string[] GetParts()
    {
        string quote = GetScripture();
        string[] parts = quote.Split("|");
        return parts;
    } 


    public void SetScripture()
    {
        _selectedScripture = GetParts();
    }

    private string ScriptureText()
    {
        string[] scripture = _selectedScripture;
        string scriptureText = scripture[1];
        return scriptureText; 
    }

    public string GetScriptureText()
    {
        string text = ScriptureText();
        return text;
    }
    

    private string RoughReference()
    {
        string[] scripture = _selectedScripture;
        string scriptureReference = scripture[0];
        return scriptureReference;

    }

    public string[] GetRefParameters()
    {
        string roughReference = RoughReference();
        var parameters = new List<string>();
        string book = roughReference.Split("~")[0];
        parameters.Add(book);
        string referenceNumbers = roughReference.Split("~")[1];

        string chapter = referenceNumbers.Split(":")[0];
        parameters.Add(chapter);
        string verses = referenceNumbers.Split(":")[1];

        if (verses.Length > 2)
        {
            string startVerse = verses.Split("-")[0];
            parameters.Add(startVerse);

            string endVerse = verses.Split("-")[1];
            parameters.Add(endVerse);
        }
        else
        {
            parameters.Add(verses);
        }

        return parameters.ToArray();


    }





    

    


}