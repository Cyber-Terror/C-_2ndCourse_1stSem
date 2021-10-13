using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    static class StaticOperations
    {
        public static int Sum(Set<int> set)
        {
            var sum = 0;
            foreach (var elem in set)
            {
                sum += elem;
            }
            return sum;
        }

        public static int Range(Set<int> set)
        {
            return set.Max() - set.Min();
        }

        public static int Count(Set<int> set)
        {
            return set.Count();
        }

        public static void DeletePositiveNumbers(this Set<int> set)
        {
            for (var i = 0; i < set.Size();)
            {
                if (set[i] > 0)
                {
                    set.Delete(set[i]);
                    --i;
                }
                ++i;
            }
        }

        public static int GetFirstNumber(this String str)
        {
            if (str.Length == 0)
            {
                throw new ArgumentException("Строка не должна быть пустой");
            }
            string numbers = "0123456789";
            var firstNumber = new StringBuilder();
            for (var i = 0; i < str.Length; ++i)
            {
                if (numbers.Contains(str[i]))
                {
                    firstNumber.Append(str[i]);
                }
                else
                {
                    if (firstNumber.Length != 0) break;
                }
            }
            return Convert.ToInt32(firstNumber.ToString());
        }
    }
}