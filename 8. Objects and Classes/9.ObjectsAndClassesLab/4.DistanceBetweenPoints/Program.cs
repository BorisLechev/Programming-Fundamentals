namespace _4.DistanceBetweenPoints
{
    using System;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPointArg = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var secondPointArg = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Point firstPoint = new Point
            {
                X = double.Parse(firstPointArg[0]),
                Y = double.Parse(firstPointArg[1]),
            };

            Point secondPoint = new Point
            {
                X = double.Parse(secondPointArg[0]),
                Y = double.Parse(secondPointArg[1]),
            };

            var result = CalcDistance(firstPoint, secondPoint);
            Console.WriteLine($"{result:f3}");
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(
                Math.Pow((secondPoint.X - firstPoint.X), 2) +
                Math.Pow((secondPoint.Y - firstPoint.Y), 2));
        }
    }
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}










