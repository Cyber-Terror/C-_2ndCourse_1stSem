using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Printer
    {
         public static void IAmPrinting(TVProgramm obj)
        {
            Console.WriteLine("Тип объекта " + obj.GetType());
            Console.WriteLine(obj.ToString());
            
        }
    }
}
