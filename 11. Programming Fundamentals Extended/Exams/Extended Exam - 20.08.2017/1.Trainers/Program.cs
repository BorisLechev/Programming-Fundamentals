namespace _1.Trainers
{
    using System;

    public class Trainers
    {
        public static void Main()
        {
            short numberOfParticipants = short.Parse(Console.ReadLine());
            double technicalTeamEarnedMoney = 0;
            double practicalTeamEarnedMoney = 0;
            double theoreticalTeamEarnedMoney = 0;

            for (int i = 0; i < numberOfParticipants; i++)
            {
                int distanceInMiles = int.Parse(Console.ReadLine());
                float cargoInTons = float.Parse(Console.ReadLine());
                string team = Console.ReadLine();

                int distanceInMeters = distanceInMiles * 1600;
                double cargoInKilograms = cargoInTons * 1000;

                double distancePrice = 0.7 * distanceInMeters * 2.5;
                double cargoPrice = 1.5 * cargoInKilograms;

                if (team == "Technical")
                {
                    technicalTeamEarnedMoney += cargoPrice - distancePrice;
                }

                if (team == "Practical")
                {
                    practicalTeamEarnedMoney += cargoPrice - distancePrice;
                }

                if (team == "Theoretical")
                {
                    theoreticalTeamEarnedMoney += cargoPrice - distancePrice;
                }
            }

            double winner = Math.Max(technicalTeamEarnedMoney, Math.Max(practicalTeamEarnedMoney, theoreticalTeamEarnedMoney));

            if (winner == technicalTeamEarnedMoney)
            {
                Console.WriteLine($"The Technical Trainers win with ${winner:f3}.");
            }

            else if (winner == practicalTeamEarnedMoney)
            {
                Console.WriteLine($"The Practical Trainers win with ${winner:f3}.");
            }

            else if (winner == theoreticalTeamEarnedMoney)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${winner:f3}.");
            }
        }
    }
}
