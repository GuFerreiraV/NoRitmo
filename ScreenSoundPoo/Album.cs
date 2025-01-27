class Album {

   private List<Music> musics = new List<Music> ();

    public Album(string albumName)
    {
        this.name = albumName;
    }

    public string name { get; set; }
    public int TotalDuration => musics.Sum(m => m.duration);


    public void AddAlbum(Music music) { 
    musics.Add(music);
    }

    public void PrintAlbumDuration() {
        Console.WriteLine($"Adicionando músicas ao álbum: {name}\n");
        foreach (var music in musics) {
            Console.WriteLine($"Música: {music.musicName}");
        }
        Console.WriteLine($"\nDuração total do álbum: {TotalDuration}");
    }
}