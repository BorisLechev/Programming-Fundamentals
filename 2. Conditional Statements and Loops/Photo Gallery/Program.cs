using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Gallery
{
    class Program
    {
        static void Main(string[] args) //!!!!!
        {
            int number = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double bytes = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: DSC_{number:d4}.jpg");
            Console.WriteLine($"Date Taken: {day}/{month}/{year} {hours}:{minutes:d2}");
            string sizeName = "B";
            if (bytes > 1000000)
            {
                bytes /= 1000000;
                sizeName = "MB";
            }
            else if (bytes > 1000)
            {
                bytes /= 1000;
                sizeName = "KB";
            }
            Console.WriteLine($"Size: {bytes}{sizeName}");
            if (width < height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
        }
    }
}
