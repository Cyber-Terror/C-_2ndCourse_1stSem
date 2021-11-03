using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
   sealed class Cartoons : Film
    {
        public Cartoons(string name, int showsPerWeek, Date datee,string zhanr, string filme)
            :base( name, showsPerWeek, datee,zhanr, filme)
        {
            Console.WriteLine("Ok");
        }

        enum Creation
        {
            painting,
            marionette,
            computer,
            plasticine,
        }
        
    }
}
