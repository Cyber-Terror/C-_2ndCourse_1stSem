using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public partial class Phone
    {
       const int hash = 1509;
       public int id;
       public string Secondname;
       public string Name;
      public string FatherName;
     public   string adress;
        int NumberOfCreditCard;
        int Debit;
        int Credit;
        static int NObjects;

        public string FNAme
        {
            get
            {
                return Secondname;
            }
            set
            {
                Secondname = value;
                if(String.IsNullOrEmpty(Secondname))
                {
                    Console.WriteLine("Error! Enter Your FatherName");
                }
                else
                {
                    Console.WriteLine("Your Second Name is " + Secondname);
                }
            }
        }
       
        public string NAme
        {
            get
            {
                return Name;
            }
            set
            {
                if (String.IsNullOrEmpty(Name))
                {
                    Name = value;
                    Console.WriteLine("Error! Enter Your FatherName");
                }
                else
                {
                    Name = value;
                    Console.WriteLine("hello"+Name);
                }
            }
        }
        static  Phone() 
        {
            Console.WriteLine("Create new Object");
        }
        public  Phone( int ID,string Second,string ADress,int Creditka)
        {
            this.id = ID;
            this.Secondname = Second;
            this.adress = ADress;
            this.NumberOfCreditCard = Creditka;
            NObjects++;
        }
        private Phone(int IED)
        {

            this.id = IED;
            Secondname = "Dimitriadi";
            adress = "Belynichy";
            Credit = 560;
        }
        public int ID()//== ID
        {
            return NumberOfCreditCard / hash;
        }
        public Phone()
        {
            
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Phone m = obj as Phone;
            if (m as Phone == null)
            {
                return false;
            }

            return m.id == id && m.Secondname == Secondname && m.adress == adress && m.NumberOfCreditCard == NumberOfCreditCard;
        }

        public bool Equals(Phone obj)
        {
            if (obj == null)
                return false;
            return obj.id == id && obj.Secondname == Secondname && obj.adress == adress && obj.NumberOfCreditCard==NumberOfCreditCard;
        }
        //public static class WritePhone
        //{
        //    public static void GetInformation(string info) => Console.WriteLine($"{info}");
        //}

        public override string ToString() => "id " + id.ToString() + ", SecondName " + Secondname.ToString() + ", adress " + adress.ToString() + ", NumberOfCreditCard "+ NumberOfCreditCard.ToString();
    }
    public class Program
    {
    
        static void Main(string[] args)
        {
            Phone ph1 = new Phone(5, "Dimitrie", "belynich", 295125195);
            Phone ph2 = new Phone(7, "Bybeloene", "chebokasri", 988214195);
            
           
            //WritePhone.GetInformation(ph1.ToString());
            Console.WriteLine(ph1.Equals(ph2));
            Console.WriteLine(ph1.ID());
            Console.WriteLine(ph2.ID());
            Console.WriteLine(ph1.ToString());
            Console.WriteLine(ph2.ToString());
            Console.WriteLine(ph2.FNAme);

            var someType = new { id = 7, Secondname = "vasya" };
            Console.WriteLine(someType);
            var array = new Phone[3];
            for(int i=0;i<array.Length;i++)
            {
                array[i] = new Phone();
                Console.WriteLine();
                Console.WriteLine($"information about №{i + 1}:");
              //  Console.WriteLine("id:");
            //    array[i].id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Инициалы:");
                array[i].Secondname = Console.ReadLine();
                Console.WriteLine("Адрес:");
                array[i].adress = Console.ReadLine();

            }
            Console.WriteLine((array[0].adress).Equals(array[1].adress));



        }
    }
}
