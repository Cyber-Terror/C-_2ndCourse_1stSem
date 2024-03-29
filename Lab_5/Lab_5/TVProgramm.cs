﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    abstract class TVProgramm
    {
        public string NameOfProgramm;
       public DateTime Date;
      public  int Duration;//
        public int ShowsPerDay;
        public static  int Count = 0;
        
            
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            TVProgramm programm = (TVProgramm)obj;
            return (this.Date == programm.Date&& this.NameOfProgramm == programm.NameOfProgramm && this.Duration == programm.Duration && this.ShowsPerDay == programm.ShowsPerDay);
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(NameOfProgramm))
                return base.ToString();
            return "Название программы; День проведения программы; Продолжительность; Количество повторений в день  " + NameOfProgramm + Date + Duration + ShowsPerDay;
        }

        public override int GetHashCode()
        {

            return Count;

        }

        public TVProgramm(string name, int showsPerWeek)
        {
            NameOfProgramm = name;
            ShowsPerDay = (showsPerWeek > 0) ? showsPerWeek : 0;
            ++Count;
        }
    }
}
