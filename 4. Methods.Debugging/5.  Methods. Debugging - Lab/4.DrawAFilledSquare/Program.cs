using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderAndFooterRow(n);
            PrintMiddleRow(n);
            PrintHeaderAndFooterRow(n);
        }

        public static void PrintHeaderAndFooterRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        public static void PrintMiddleRow(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('-');

                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}
