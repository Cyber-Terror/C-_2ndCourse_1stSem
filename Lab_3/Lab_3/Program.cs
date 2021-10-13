using System;

namespace Lab_3
{
    static class Program
    {
        static void Main(string[] args)
        {
            var set1 = new Set<int>() { 1, 2, 3, 4 };
            var set2 = new Set<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine(set1 > set2);
            var intersection = set1 * set2;
            foreach (var elem in intersection)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine(((Owner.Date)set1).DateOfSeptember);
            Console.WriteLine(set1.Max());
            var set3 = new Set<string> { "", "u789" };
            Console.WriteLine(set3.Min());
            var set5 = new Set<int>() { -1, -2, -5, 3, 1, 9 };
            set5.DeletePositiveNumbers();
            foreach (var elem in set5)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine(set3[1].GetFirstNumber());
        }
    }
}