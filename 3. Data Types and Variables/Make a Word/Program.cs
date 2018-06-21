using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_a_Word // !!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            string word = string.Empty;
            for (int i = 0; i < numberOfLines; i++)
            {
                word += Console.ReadLine();
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
