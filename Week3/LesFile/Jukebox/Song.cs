
public class Song
{
    public string Title; 
    public string Artist; 
    public int Duration; 

    public Song(string title, string artist, int duration)
    {
        Title = title;
        Artist = artist;
        Duration = duration; //what if duration has a negative value
    }
    
    public string Info() => $"'{Title}' performed by '{Artist}' - {Duration / 60}m:{ Duration % 60}s";
    /*
    {
        TimeSpan t = TimeSpan.FromSeconds(Duration);
        return $"'{Title}' performed by '{Artist}' - {t.Minutes:D2}m:{t.Seconds:D2}s";
    }*/
    
    public override string ToString()=> Info();
}