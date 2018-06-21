using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipment //!!!!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            double subTotal = 0;
            double moneyLeft = 0;
            for (int i = 0; i < numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int quantity = int.Parse(Console.ReadLine());
                subTotal += quantity * itemPrice;
                moneyLeft = Math.Abs(budget - subTotal);

                if (budget >= itemPrice && quantity == 1)
                {
                    Console.WriteLine($"Adding {quantity} {itemName} to cart.");
                }
                else if (budget >= itemPrice && quantity > 1)
                {
                    Console.WriteLine($"Adding {quantity} {itemName}s to cart.");
                }
                if (budget < subTotal)
                {
                    Console.WriteLine($"Subtotal: ${subTotal:f2}");
                    Console.WriteLine($"Not enough. We need ${moneyLeft:f2} more.");
                    return;
                }
            }
            Console.WriteLine($"Subtotal: ${subTotal:f2}");
            Console.WriteLine($"Money left: ${moneyLeft:f2}");
        }
    }
}
