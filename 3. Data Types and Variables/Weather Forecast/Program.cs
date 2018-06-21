using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast //!!!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            sbyte sbyteNumber = 0;
            int intNumber = 0;
            long longNumber = 0;
            if (sbyte.TryParse(number, out sbyteNumber)) 
            {
                Console.WriteLine("Sunny");
            }
            else if (int.TryParse(number, out intNumber))
            {
                Console.WriteLine("Cloudy");
            }
            else if (long.TryParse(number, out longNumber))
            {
                Console.WriteLine("Windy");
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
