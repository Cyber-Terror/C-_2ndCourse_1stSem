using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab_5
{
    public class Exceptions : System.Exception
    {
        public string ErrorClass { get; set; }
        public Exceptions(string message, string errorClass)
            : base(message)  // наследуем message от System.Exception
        {
            this.ErrorClass = errorClass;
        }
    }

    public class DateExceptions : Exceptions
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public DateExceptions(string message, int errorMonth, int errorYear)
            : base(message, "Error code 1: Uncorrected date\n")
        {
            Month = errorMonth;
            Year = errorYear;
        }


    }
    public class NameExceptions : Exceptions
    {
        public string Name { get; set; }

        public NameExceptions(string message, string errorName)
            : base(message, "Error code 2: Uncorrected Name\n")
        {
            Name = errorName;
        }

    }

    public class CountExceptions : Exceptions
    {
        public int Count { get; set; }

        public CountExceptions(string message, int errorAds)
            : base(message, "Error code 2: Uncorrected Ads\n")
        {
            Count = errorAds;
        }

    }



    ///
    public class FileLogger
    {
        public FileLogger() { }
        public void WriteLog(Exceptions exception)
        {
            DateExceptions DateEx = exception as DateExceptions;
            NameExceptions NameEx = exception as NameExceptions;
            CountExceptions CountEx = exception as CountExceptions;
            

            string filePath = @"C:\University_work\OAP\2kyrs\Labs\Lab_7\Lab_5\log.txt";
            using StreamWriter streamWriter = new StreamWriter(filePath, true, System.Text.Encoding.Default);
            streamWriter.WriteLine(DateTime.Now);
            if (DateEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}.{3}", DateEx.ErrorClass, DateEx.Message, DateEx.Month, DateEx.Year); ;
            }
            if (NameEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", NameEx.ErrorClass, NameEx.Message, NameEx.Name);
            }
            if (CountEx != null)
            {
                streamWriter.WriteLine("{0}{1} ",CountEx.ErrorClass, CountEx.Message);
            }
          
        }
    }

    public class ConsoleLogger
    {
        public ConsoleLogger() { }
        public void WriteLog(Exceptions exception)
        {
            DateExceptions DateEx = exception as DateExceptions;
            NameExceptions NameEx = exception as NameExceptions;
            CountExceptions CountEx = exception as CountExceptions;

            Console.WriteLine("\n" + DateTime.Now);
            if (DateEx != null)
            {
                Console.WriteLine("{0}{1} {2}.{3}.{4}", DateEx.ErrorClass, DateEx.Message, DateEx.Month, DateEx.Year); ;
            }
            if (NameEx != null)
            {
                Console.WriteLine("{0}{1} {2}", NameEx.ErrorClass, NameEx.Message, NameEx.Name);
            }
            if (CountEx != null)
            {
                Console.WriteLine("{0}{1} ", CountEx.ErrorClass, CountEx.Message);
            }
          
        }
    }
}
