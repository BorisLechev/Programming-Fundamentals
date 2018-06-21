using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow // !!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte sum = 0;
            for (int times = 0; times < n; times++)
            {
                short commingLitres = short.Parse(Console.ReadLine());
                if (sum + commingLitres > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += (byte)commingLitres;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
