using System;

namespace Lab_5
{
    class main
    {
        static void Main(string[] args)
        {
            ProgrammController Container = new ProgrammController();
            Ads advert = new Ads("Vasya",14,new Date(16, 2021), "MoiDoDir");
          
            Cartoons carton = new Cartoons("Bodya", 14, new Date(48, 2021),"Basnya", "Betrayal");
            ArtisticFilm artist1 = new ArtisticFilm("Sasha",88, new Date(16, 2021),"Folklor","DeadIsland",new string[] { "Semis"});
            Console.WriteLine(advert.ToString());
            Console.WriteLine(carton.ToString());
            Console.WriteLine(artist1.ToString());
            Container.Add(advert);
            Container.Add(carton);
            Container.Add(artist1);
           Container.CountOfRoliks();
            Container.CountTimeImba(15);
            Container.SearchFilm(new Date(16,2021));

        }

        
    }
}
