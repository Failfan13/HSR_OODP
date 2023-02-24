public class MyJukebox
{

    List<Song> Playlist = new() { };

    public string PlayListDuration()
    {   
        var t = 0;//Playlist.Sum(song => song.Duration);
        foreach (var song in Playlist)  {
            t += song.Duration;
        }
        return $"{t / 60}m:{t % 60}s";
    }

    public void AddSong(string title, string artist, int duration)
    {
        Playlist.Add(new Song(title, artist, duration));
    }

    //public string Info() => (Playlist.Count() > 0)? string.Join("\n", Playlist) : "No songs currently in Playlist!"; 

    public string Info() => (Playlist.Count() > 0)? StringifyPlayList() : "No songs currently in Playlist!"; 

    string StringifyPlayList() { 
        var res = "";
        foreach (var song in Playlist)
            res += song + "\n";
        return res;
    }
    
    public Song GetLastSong() => Playlist[Playlist.Count - 1];
    public int HowManySongs() => Playlist.Count;
    
    public override string ToString() => Info();

}