using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Ads : TVProgramm
    {
      public  string AdsProducts;
        //public override string ToString()
        //{
        //    if (String.IsNullOrEmpty(AdsProducts))
        //        return base.ToString();
        //    return "Продукты рекламируемые: " + AdsProducts;
        //}

        public Ads(string name, int showsPerWeek,Date datee,string ads )
           :base(name, showsPerWeek,datee)
        {
            this.Date = datee;
            AdsProducts = ads;
        }
        
    }
}
