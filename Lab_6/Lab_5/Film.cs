﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
  abstract  class Film :TVProgramm,IMovie
    {
       // public Date Dataa;
        public string Ganre;
        public string Films;
       
        public Film(string name, int showsPerWeek, Date datee,string Zhanr, string felm)
            :base(name,showsPerWeek,datee)
        {
            this.Date = datee;
            Ganre = Zhanr;
            Films = felm;
            
        }
        public void Movie()
        {
            Console.WriteLine("Фильм пошел");
        }
        
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Ganre))
                return base.ToString();
            return "Жанр: " + Ganre + " Название фильма: " + Films + " Дата выхода: " + Date.month+"." + Date.year+".";
        }
    }

}
