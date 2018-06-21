using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string unitToConvert = Console.ReadLine();
            double valueToConvert = double.Parse(Console.ReadLine());
            switch (unitToConvert)
            {
                case "miles":
                    Console.WriteLine($"{valueToConvert} {unitToConvert} = {valueToConvert * 1.6:f2} kilometers"); break;
                case "inches":
                    Console.WriteLine($"{valueToConvert} {unitToConvert} = {valueToConvert * 2.54:f2} centimeters"); break;
                case "feet":
                    Console.WriteLine($"{valueToConvert} {unitToConvert} = {valueToConvert * 30:f2} centimeters"); break;
                case "yards":
                    Console.WriteLine($"{valueToConvert} {unitToConvert} = {valueToConvert * 0.91:f2} meters"); break;
                case "gallons":
                    Console.WriteLine($"{valueToConvert} {unitToConvert} = {valueToConvert * 3.8:f2} liters"); break;
            }
        }
    }
}
