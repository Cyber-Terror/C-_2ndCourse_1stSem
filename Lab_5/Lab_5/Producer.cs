using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Producer : IPeople
    {
      public  string Name { get; set; }
        public Producer(string name)
        {
            Name = name;
        }
    }
}
