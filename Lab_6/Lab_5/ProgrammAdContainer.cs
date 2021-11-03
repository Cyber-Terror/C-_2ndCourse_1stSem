using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
 public   class ProgrammAdContainer
    {
        public List<TVProgramm> TVPeredacha;
        public ProgrammAdContainer()
        {
            TVPeredacha = new List<TVProgramm>();
        }
        public void Delete(int index)
        {
            TVPeredacha.RemoveAt(index);
        }
        public void Add(TVProgramm item)
        {
            TVPeredacha.Add(item);
        }
        public void Cout()
        {
            foreach (TVProgramm elem in TVPeredacha)
            {
                Console.WriteLine(elem);
            }
        }
        
    }
}
