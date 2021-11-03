using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class ArtisticFilm : Film
    {
        public string[] actors;
        //public string Actoris;
        //Actoris+=actors.value;
        public ArtisticFilm(string name, int showsPerWeek, Date datee, string Zhanr, string felm,string[] actor)
            :base(name, showsPerWeek,datee, Zhanr,felm)
        {
            actors = actor;
        }

    }
}
