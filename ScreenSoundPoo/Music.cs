class Music
{

    //properties
    public int duration { get; set; }
    public Band artist { get; }
    public string musicName { get; set; }
    public bool available { get; set;}
    public Gender gender { get; set; }

    public Music(Band artist, string musicName, Gender gender) { 
        this.artist = artist;
        this.musicName = musicName;
        this.gender = gender;
    }

    public string Description => $"A música {musicName} é da banda {artist}";

    public void ViewTechnicalSheet() 
    {
        Console.WriteLine($"Nome do artista: {artist.bandName}");
        Console.WriteLine($"Nome da música: {musicName}");
        Console.WriteLine($"Gênero: {gender.genderName}");
        Console.WriteLine($"Duração: {duration}");
        if (available)
        {
            Console.WriteLine("disponível no plano basic");
        }
        else {
            Console.WriteLine("Adquira o plano advanced");
        }
        }


}

 