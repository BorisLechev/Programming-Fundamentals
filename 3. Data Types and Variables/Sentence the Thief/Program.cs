using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_the_Thief // ?????????????
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
            long closesNumber = currentNumber;
            for (int i = 0; i < n; i++)
            {
                currentNumber = long.Parse(Console.ReadLine());
                if (Math.Abs(equalToMaxValue - currentNumber) < (Math.Abs(equalToMaxValue - closesNumber)))
                {
                    closesNumber = currentNumber;
                }
            }
            int divider = closesNumber < 0 ? 128 : 127;
            double sentence = Math.Abs(Math.Ceiling((double)Math.Abs(closesNumber) / divider));
            Console.WriteLine(sentence > 1 ?
                $"Prisoner with id {closesNumber} is sentenced to {sentence} years" :
                $"Prisoner with id {closesNumber} is sentenced to {sentence} year");
        }
    }
}
