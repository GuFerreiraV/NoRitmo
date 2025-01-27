Episodes ep1 = new Episodes(1,"Meus ovo", 30);
ep1.AddGuests("Gustavo");
Episodes ep2 = new Episodes(2, "Meus ovo 2", 25);
ep2.AddGuests("Camilly");
Episodes ep3 = new Episodes(3, "Meus ovo 3", 45);
ep3.AddGuests("André");


Podcast podcast = new Podcast("Meu talkshow", "Naruto");
podcast.AddEpisode(ep1);
podcast.AddEpisode(ep2);
podcast.AddEpisode(ep3);
podcast.PrintDetails();