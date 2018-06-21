using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_Kegs // !!!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double volumeOfTheBiggestKeg = 0;
            double tempVolume = 0;
            string modelAtTheBiggestKeg = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string modelOfTheCurrentKeg = Console.ReadLine();
                double radiusOfTheCurrentKeg = double.Parse(Console.ReadLine());
                int heightOfTheCurrentKeg = int.Parse(Console.ReadLine());
                tempVolume = Math.PI * Math.Pow(radiusOfTheCurrentKeg, 2) * heightOfTheCurrentKeg;
                if (volumeOfTheBiggestKeg < tempVolume)
                {
                    volumeOfTheBiggestKeg = tempVolume;
                    modelAtTheBiggestKeg = modelOfTheCurrentKeg;
                }
            }
            Console.WriteLine(modelAtTheBiggestKeg);
        }
    }
}
