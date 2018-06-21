using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Builder // !!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string lastNumber = Console.ReadLine();
            sbyte someSbyte = 0;
            if (sbyte.TryParse(firstNumber, out someSbyte))
            {
                Console.WriteLine(someSbyte * 4 + long.Parse(lastNumber) * 10);
            }
            else
            {
                Console.WriteLine(long.Parse(lastNumber) * 4 + long.Parse(firstNumber) * 10);
            }
        }
    }
}
