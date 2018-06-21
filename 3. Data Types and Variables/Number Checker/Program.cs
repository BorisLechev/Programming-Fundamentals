using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Checker // !!!!!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredNumber = Console.ReadLine();
            Console.WriteLine(enteredNumber.Contains(".")? "floating-point" : "integer");
        }
    }
}
