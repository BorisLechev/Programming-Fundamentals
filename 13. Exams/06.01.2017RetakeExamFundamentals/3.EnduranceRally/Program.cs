namespace _3.EnduranceRally
{
    using System;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            var driversNames = Console.ReadLine().Split(' ').ToList();
            var trackZones = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var checkPointIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            foreach (var driver in driversNames)
            {
                double startingFuel = driver[0];
                int checkPoints = 0;

                for (int i = 0; i < trackZones.Count; i++)
                {
                    bool isEqual = false;

                    for (int j = 0; j < checkPointIndexes.Count; j++)
                    {
                        if (i == checkPointIndexes[j])
                        {
                            isEqual = true;
                            break;
                        }
                    }

                    if (isEqual)
                    {
                        startingFuel += trackZones[i];
                    }

                    else
                    {
                        startingFuel -= trackZones[i];
                    }

                    if (startingFuel > 0)
                    {
                        checkPoints++;
                    }

                    else
                    {
                        Console.WriteLine($"{driver}- reached {checkPoints}");
                        break;
                    }
                }

                if (startingFuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {startingFuel:f2}");
                }
            }
        }
    }
}
