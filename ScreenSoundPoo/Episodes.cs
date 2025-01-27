class Episodes { 

    private readonly List<string> Guest = new List<string>();
    public int Duration { get;}
    public int Order { get; }
    public string titleEp { get; }
    public string Resume => $"{Order}° episódio - {titleEp}\nDuração: {Duration} min\nConvidados: {string.Join(", ", Guest)}";
    // concatena com Order, titulo, Duration e convidados

    public Episodes(int order, string titleEp, int duration)
    {
        this.titleEp = titleEp;
        this.Duration = duration;
        this.Order = order;
    }

    public void AddGuests(params string[] guests) => Guest.AddRange(guests);
    
   
}