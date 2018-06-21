using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers //!!!!!!!!!!!!!!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            for (int i = 1; i <= n; i++)
            {
                int digits = i;
                while (i > 0)
                {
                    sumOfDigits += i % 10;
                    i = i / 10;
                }
                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{digits} -> {special}");
                sumOfDigits = 0;
                i = digits;
            }
        }
        }
    }
}
