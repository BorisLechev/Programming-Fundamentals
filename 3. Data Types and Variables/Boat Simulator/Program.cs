using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Simulator //!!!!!!!!!!!!?????????????????
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            byte firstBoatSpeed = 0;
            byte secondBoatSpeed = 0;
            byte movesCounterFirstBoat = 0;
            byte movesCounterSecondBoat = 0;
            for (int i = 1; i <= n; i++)
            {
                string boatSpeed = Console.ReadLine();
                if (boatSpeed == "UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                    continue;
                }
                if (i % 2 == 1)
                {
                    firstBoatSpeed += (byte)boatSpeed.Length;
                    if (firstBoatSpeed >= 50)
                    {
                        Console.WriteLine(firstBoat); break;
                    }
                    movesCounterFirstBoat++;
                }
                else
                {
                    secondBoatSpeed += (byte)boatSpeed.Length;
                    if (secondBoatSpeed >= 50)
                    {
                        Console.WriteLine(secondBoat); break;
                    }
                    movesCounterSecondBoat++;
                }
            }
            if (firstBoatSpeed < 50 && secondBoatSpeed < 50)
            {
                Console.WriteLine(movesCounterFirstBoat > movesCounterSecondBoat ? firstBoat : secondBoat);
            }
        }
    }
}
