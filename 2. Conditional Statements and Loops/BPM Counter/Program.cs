using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM_Counter //!!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());
            double time = numberOfBeats / beatsPerMinute * 60;
            double durationInMinutes = Math.Floor(time / 60);
            double durationInSeconds = Math.Floor(time % 60);
            double bars = Math.Round(numberOfBeats / 4, 1);
            Console.WriteLine($"{bars} bars - {durationInMinutes}m {durationInSeconds}s");
        }
    }
}
