class Podcast{
    
    public string Host { get;}
    public string Name { get;}
    public int EpisodesTotal => Episodes.Count;
    private readonly List<Episodes> Episodes = new ();

    public Podcast(string name, string host) { 
        this.Name = name;
        this.Host = host;
    }
    public void AddEpisode(Episodes episode) => Episodes.Add(episode);

    public void PrintDetails() {

        Console.WriteLine($"Podcast: {Name}, apresentado por {Host}\n");

        // ordena a lista de eps com base no numero de eps (var order)
        Episodes.Sort((e1, e2) => e1.Order.CompareTo(e2.Order));
        

        Episodes.ForEach(ep => Console.WriteLine(ep.Resume));
        Console.WriteLine($"Total de eps: {EpisodesTotal}");
    }

}