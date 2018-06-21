namespace _9.LongerLine
{
    using System;

    public class LongerLine
    {
        public static void Main()
        {
            double pointOneX1 = double.Parse(Console.ReadLine());
            double pointOneY1 = double.Parse(Console.ReadLine());
            double pointOneX2 = double.Parse(Console.ReadLine());
            double pointOneY2 = double.Parse(Console.ReadLine());

            double pointTwoX1 = double.Parse(Console.ReadLine());
            double pointTwoY1 = double.Parse(Console.ReadLine());
            double pointTwoX2 = double.Parse(Console.ReadLine());
            double pointTwoY2 = double.Parse(Console.ReadLine());

            double first = LongestLine(pointOneX1, pointOneY1, pointOneX2, pointOneY2);
            double second = LongestLine(pointTwoX1, pointTwoY1, pointTwoX2, pointTwoY2);

            if (first >= second)
            {
                ClosestPoint(pointOneX1, pointOneY1, pointOneX2, pointOneY2);
            }

            else
            {
                ClosestPoint(pointTwoX1, pointTwoY1, pointTwoX2, pointTwoY2);
            }
        }

        public static double LongestLine(double x1, double y1, double x2, double y2)
        {
            double longestLine = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            return longestLine;
        }

        public static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double first = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double second = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (first <= second)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }

            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
