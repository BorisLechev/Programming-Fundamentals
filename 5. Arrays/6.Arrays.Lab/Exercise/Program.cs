using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[Math.Max(arr.Length, arr2.Length)];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = arr[i % arr.Length] + arr2[i % arr2.Length];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
