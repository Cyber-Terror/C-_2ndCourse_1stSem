using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class News : TVProgramm
    {
        public string TVPresetner;
        public string[] VarietiesOfProgramms;
        public News(string name, int showsPerWeekstring, string TVprest, string[] VarietiesOfpog)
        : base(name, showsPerWeekstring)
        {

            TVPresetner = TVprest;
            VarietiesOfProgramms = VarietiesOfpog;
        }
       


        public override string ToString()
        {
            string safe = "";
            for (int i=0;i<VarietiesOfProgramms.Length;i++)
            {
                 safe+= VarietiesOfProgramms[i];
                
            }
            if (String.IsNullOrEmpty(TVPresetner))
                return base.ToString();
            return "ТВ Ведущий: " + TVPresetner + " Виды программ: " + safe;
        }
        
    }
}
