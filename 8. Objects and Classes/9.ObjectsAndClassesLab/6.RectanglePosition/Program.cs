namespace _6.RectanglePosition
{
    using System;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangle = new Rectangle(Console.ReadLine());
            var secondRectangle = new Rectangle(Console.ReadLine());

            Console.WriteLine(firstRectangle.IsInside(firstRectangle, secondRectangle) ? "Inside" : "Not inside");
        }
    }

    public class Rectangle
    {
        public int Top { get; }
        public int Left { get; }
        public int Right { get; }
        public int Bottom { get; }

        public Rectangle(string numbers)
        {
            var input = numbers.Split(' ').Select(int.Parse).ToList();
            Left = input[0];
            Top = input[1];
            Right = Left + input[2];
            Bottom = Top + input[3];
        }

        public bool IsInside(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            return Left >= secondRectangle.Left
                && Right <= secondRectangle.Right
                && Top <= secondRectangle.Top
                && Bottom <= secondRectangle.Bottom;
        }
    }
}
