namespace _10.CubeProperties
{
    using System;

    public class CubeProperties
    {
        public static void Main()
        {
            double lengthOfTheSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    LengthOfTheFaceDiagonals(lengthOfTheSide);
                    break;

                case "space":
                    LengthOfTheSpaceDiagonals(lengthOfTheSide);
                    break;

                case "volume":
                    VolumeOfTheCube(lengthOfTheSide);
                    break;

                case "area":
                    SurfaceArea(lengthOfTheSide);
                    break;
            }
        }

        public static void LengthOfTheFaceDiagonals(double lengthOfTheSide)
        {
            double faceDiagonals = Math.Sqrt(2 * Math.Pow(lengthOfTheSide, 2));

            Console.WriteLine($"{faceDiagonals:f2}");
        }

        public static void LengthOfTheSpaceDiagonals(double lengthOfTheSide)
        {
            double spaceDiagonals = Math.Sqrt(3 * Math.Pow(lengthOfTheSide, 2));

            Console.WriteLine($"{spaceDiagonals:f2}");
        }

        public static void VolumeOfTheCube(double lengthOfTheSide)
        {
            double volume = Math.Pow(lengthOfTheSide, 3);

            Console.WriteLine($"{volume:f2}");
        }

        public static void SurfaceArea(double lengthOfTheSide)
        {
            double surfaceArea = 6 * Math.Pow(lengthOfTheSide, 2);

            Console.WriteLine($"{surfaceArea:f2}");
        }
    }
}
