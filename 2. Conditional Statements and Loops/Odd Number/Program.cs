using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Number //!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            while (true)
            {
                if (n % 2 == 1)
                {
                    Console.WriteLine($"The number is: {n}"); break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
