namespace _3.IntersectionOfCircles
{
    using System;

    public class IntersectionOfCircles
    {
        public class Circle
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Radius { get; set; }
        }

        public static void Main()
        {
            var firstCircleData = Console.ReadLine().Split(' ');
            var secondCircleData = Console.ReadLine().Split(' ');

            var firstCircle = new Circle()
            {
                X = int.Parse(firstCircleData[0]),
                Y = int.Parse(firstCircleData[1]),
                Radius = int.Parse(firstCircleData[2])
            };

            var secondCircle = new Circle()
            {
                X = int.Parse(secondCircleData[0]),
                Y = int.Parse(secondCircleData[1]),
                Radius = int.Parse(secondCircleData[2])
            };

            if (Intersect(firstCircle, secondCircle) == true)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            var distance = Math.Sqrt(
                Math.Pow((firstCircle.X - secondCircle.X), 2) + Math.Pow((firstCircle.Y - secondCircle.Y), 2));

            if (distance <= firstCircle.Radius + secondCircle.Radius)
            {
                return true;
            }

            return false;
        }
    }
}
