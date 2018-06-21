using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Chars // !!!!!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int ASCIISum = 0;
            for (int i = 0; i < n; i++)
            {
                ASCIISum += char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum equals: {ASCIISum}");
        }
    }
}
