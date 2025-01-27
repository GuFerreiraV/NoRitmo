class Band{
    private List<Album> albums = new List<Album>();

    public Band(string bandName)
    {
        this.bandName = bandName;
    }

    public string bandName { get; set;}

    public void AddBand(Album album) {
       albums.Add(album);
    }

    public void Discography() {
        Console.WriteLine($"Discografia da banda: {bandName}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.name} ({album.TotalDuration})");
        }

    }
}