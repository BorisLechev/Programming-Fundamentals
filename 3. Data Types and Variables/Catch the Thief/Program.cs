using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catch_the_Thief // !!!!!!!!!!!!!!!!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());
            decimal equalToMaxValue = 0;
            if (numeralType == "sbyte") { equalToMaxValue = sbyte.MaxValue; }
            if (numeralType == "int") { equalToMaxValue = int.MaxValue; }
            if (numeralType == "long") { equalToMaxValue = long.MaxValue; }
            long currentNumber = 0;
            long closestNumber = currentNumber;
            for (int i = 0; i < n; i++)
            {
                currentNumber = long.Parse(Console.ReadLine());
                if (Math.Abs(equalToMaxValue - currentNumber) < Math.Abs(equalToMaxValue - closestNumber))
                {
                    closestNumber = currentNumber;
                }
            }
            Console.WriteLine(closestNumber);
        }
    }
}
