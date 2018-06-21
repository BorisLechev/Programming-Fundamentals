namespace Rectangle_Area
{
    using System;

    public class Rectangle_Area
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;

            Console.WriteLine($"{area:f2}");
        }
    }
}
