using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vapor_Store //!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyLeft = double.Parse(Console.ReadLine());
            double moneySpent = 0;
            while (moneyLeft > 0)
            {
                double gamePrice = 0;
                string gameBought = Console.ReadLine();
                switch (gameBought)
                {
                    case "OutFall 4": gamePrice = 39.99; break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    case "Game Time": Console.WriteLine($"Total spent: ${moneySpent:f2}. Remaining: ${moneyLeft:f2}"); return;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                if (moneyLeft >= gamePrice)
                {
                    Console.WriteLine($"Bought {gameBought}");
                    moneySpent += gamePrice;
                    moneyLeft -= gamePrice;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            Console.WriteLine("Out of money!");
        }
    }
}
