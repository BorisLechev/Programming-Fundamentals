namespace _11.GeometryCalculator
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            string figureType = Console.ReadLine();

            switch (figureType)
            {
                case "triangle":
                    TriangleArea();
                    return;

                case "rectangle":
                    RectangleArea();
                    break;

                case "square":
                    SquareArea();
                    break;

                case "circle":
                    CircleArea();
                    break;
            }
        }

        public static void TriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = side * height / 2;

            Console.WriteLine($"{area:f2}");
        }

        public static void RectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            
            double area = width * height;

            Console.WriteLine($"{area:f2}");
        }

        public static void SquareArea()
        {
            double side = double.Parse(Console.ReadLine());

            double area = Math.Pow(side, 2);

            Console.WriteLine($"{area:f2}");
        }

        public static void CircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            
            double area = (Math.PI * Math.Pow(radius, 2));

            Console.WriteLine($"{area:f2}");
        }
    }
}
