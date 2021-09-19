using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///                                                               1
            var v = 0;
           bool bul = true;
            byte bit1 = 1;
           sbyte bit2 = -102;
            int typeInt = 4;
            uint a = 10;
            short tShort = 8;
            ushort n2 = 102;
          double tDouble = 4.4444444444d;
           float tFloat =  5.644f;           
           char tChar = 'h';
            long tLong = -10000676887;
            ulong tuLong = 104124124551;
            decimal dec = 144.734342m;
            object Object = "Object";

            Console.WriteLine(v);
            Console.WriteLine(bul);
            Console.WriteLine(bit1);
            Console.WriteLine(bit2);
            Console.WriteLine(typeInt);
            Console.WriteLine(a);
            Console.WriteLine(tShort);
            Console.WriteLine(n2);
           Console.WriteLine(tDouble);
            Console.WriteLine(tFloat);
            Console.WriteLine(tChar);
            Console.WriteLine(tLong);
            Console.Write(tuLong);
            Console.WriteLine(dec);
            Console.WriteLine(Object);

            ///
            typeInt = (int)tDouble;
           Convert.ToDouble(dec);
             Convert.ToInt32(dec);
            Convert.ToChar(tShort);
            Convert.ToInt32(tFloat);
            ///
            a = n2;
            tFloat=bit1;
            tDouble = typeInt;
            dec = typeInt;
            tFloat = typeInt;
            /////
            int box = 44;
            Object obox = box;
            int primetbox =(int)obox;
            Console.WriteLine("Распоковка primetbox = " +primetbox);
            ///
            var number = 55;
            var str = "String";
            Console.WriteLine($"int = {number} and string = {str}");
          //  int? nulable = null;
            int? z = 2;
            int t = z ?? 2;
            Console.WriteLine(t);
            //
            // var erorr = 5;
            //error = 5.77;
            //когда мы опрелелили тип error его больше менять нелья

            //                                                            2
            String first = "allladin";
            String second = "Evangelion";
            Console.WriteLine(first == second ? true : false);
            string lit1 = @"C:\Windows\user";
            string lit2 = "C:\\Windows\\user";
            string lit3 = "C:/Windows/user";
            Console.WriteLine($"{lit1}\n{lit2}\n{lit3}\n===========================");
            String v1 = "All ";
            String v2 = "Will be fine ";
            String v3 = String.Copy(v1);
            String v4 = v2.Substring(8, 4);
            Console.WriteLine(String.Concat(v1, v2));
            Console.WriteLine(v4 +" "+ v3);
            Console.WriteLine(v2.Split(' ')[0]+v2.Split(' ')[1]+v2.Split(' ')[2]);
            Console.WriteLine(v1.Insert(4,v2));
            Console.WriteLine(v1.Remove(1));
            /////
            String vstr = "";
            String nstr = null;
            Console.WriteLine(vstr.GetType());
            Console.WriteLine(vstr);
            Console.WriteLine(nstr);
            Console.WriteLine("{0}\t{1}", vstr.Length, vstr == nstr);
            nstr = "help";
            Console.WriteLine("{0} \n===========================", nstr);
            StringBuilder AD = new StringBuilder("Dimitriadi", 55);
            AD=AD.Append(" Anton");
            AD = AD.Insert(0, "Goodlike");
            AD = AD.Remove(8,10);
            Console.WriteLine(AD);
            ////// 3
            int[,] mas = { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 } };
            for(int i=0;i<3;i++)
            {
                for(int l=0;l<3;l++)
                {
                    Console.Write(mas[i, l] + " ");
                }
                Console.WriteLine();
            }
            //String[] smas = {"aa","nnn","tttt","ooooo","n" };
            //for (int pp = 0; pp < smas.Length; pp++)
            //{
            //    Console.Write(smas[pp] + " ");
            //}
            //    Console.Write("Длина массива = " + smas.Length+"\n");
            //Console.WriteLine("Введите новый эл-т массива");
            //int position = Convert.ToInt32(Console.ReadLine());
            //smas[position] = Console.ReadLine();
            //for(int j=0;j<smas.Length;j++)
            //{
            //    Console.Write(smas[j] + " ");
            //}
            Console.WriteLine();
            //int[][] maciv = { new int[2], new int[3], new int[4] };
            //for(int qq=0;qq<2;qq++)
            //{
            //    maciv[0][qq] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int qq = 0; qq < 3; qq++)
            //{
            //    maciv[1][qq] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int qq = 0; qq < 4; qq++)
            //{
            //    maciv[2][qq] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach(int[] elem in maciv)
            //{
            //    foreach(int qq in elem)
            //    {
            //        Console.Write("\t" + qq);
            //    }
                //Console.WriteLine();
                var vrmas = new[] { 2, 'c', -666 };
                Console.Write("Massiv ");
                for(int i=0;i<vrmas.Length;i++)
                {
                    Console.Write(vrmas[i]+ " ");
                }
            Console.WriteLine(vrmas.GetType());
            var vrstring = "Stroki tozhe lydi";
            Console.WriteLine(vrstring + " " + vrstring.GetType());
            ///////
            (int, string, char, string, ulong) kortez = (14, "Unbreakable", 'f', "Poit", 5);
            var kor2 = (Nomer: 6, Spec: "POIT", Val: 'G', Fac: "FIT", Kol: 29);
            Console.WriteLine(kortez);
            Console.WriteLine(kortez.Item4 +" "+ kortez.Item2);
            var (Nomer, Brutal, Val, Fac, Kol) = (kortez.Item1, kortez.Item2, kortez.Item3, kortez.Item4, kortez.Item5);
            Console.WriteLine(Nomer + " " + Brutal + " " + Kol + " ");
            Console.Write("Кортежи {0} и {1} - {2}", kortez, kor2, Equals(kortez, kor2) ? "равны\n" : "не равны\n");
            /////
            (int ,int ,int ,char) LocFunc (int[] massive ,string stroka)
            {
                int min = massive[0], max = massive[0], sum = 0;
                for(int d=0;d<massive.Length;d++)
                {
                    if (massive[d] < min)
                    {
                        min = massive[d]; ;
                    }
                    if (massive[d] > max)
                    {
                        max = massive[d]; ;
                    }
                    sum += massive[d];
                }
                var result = (min, max, sum, stroka[0]);
                return result;
            }
            int[] massiv = { 0, -8, 7, 4, 15 };
            string stro4ka = "fuf";
            var kort4 = LocFunc(massiv, stro4ka);
            Console.WriteLine($"Минимальный элемент:{kort4.Item1}\nМаксимальный элемент:{kort4.Item2}\nСумма элементов:{kort4.Item3}\nПервый символ строки: {kort4.Item4}");
            int  chekornot= 20;
            int FuncChek()
            {
                int m = int.MaxValue;
                checked
                {
                    m = m + chekornot;
                    Console.WriteLine(m);
                }
                return m;
            }
            int FuncUncheked()
            {
                int m = int.MaxValue;
                unchecked
                {
                    m = m + chekornot;
                    Console.WriteLine(m);
                }
                return m;
            }
            Console.WriteLine(FuncUncheked());
            Console.WriteLine(FuncChek());
        }
    }
    }
