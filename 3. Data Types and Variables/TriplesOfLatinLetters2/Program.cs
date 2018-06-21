using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLatinLetters2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int first = 97; first < 97 + n; first++)
            {
                for (int second = 97; second < 97 + n; second++)
                {
                    for (int third = 97; third < 97 + n; third++)
                    {
                        Console.WriteLine($"{(char)first}{(char)second}{(char)third}");
                    }
                }
            }
        }
    }
}
