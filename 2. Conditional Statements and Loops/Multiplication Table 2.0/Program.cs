using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_2._0 //!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            int product = 0;
            do
            {
                product = n * times;
                Console.WriteLine($"{n} X {times} = {product}");
                times++;
            } while (times <= 10);
        }
    }
}
