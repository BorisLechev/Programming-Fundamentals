namespace _5.ParkingValidation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ParkingValidation
    {
        public static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var database = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var register = Console.ReadLine().Split(' ').ToList();
                string username = register[1];

                if (register[0] == "register")
                {
                    string licensePlateNumber = register[2];

                    if (database.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }

                    else if (!isValid(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                    }

                    else if (database.ContainsValue(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                    }

                    else
                    {
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        database[username] = licensePlateNumber;
                    }

                }

                else if (register[0] == "unregister")
                {
                    if (database.ContainsKey(username))
                    {
                        Console.WriteLine($"user {username} unregistered successfully");
                        database.Remove(username);
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }

                    foreach (var car in database)
                    {
                        Console.WriteLine($"{car.Key} => {car.Value}");
                    }
                }
            }
        }

        public static bool isValid(string licensePlateNumber)
        {
            return

            licensePlateNumber.Length == 8
                && licensePlateNumber.Take(2).All(x => x >= 'A' && x <= 'Z')
                && licensePlateNumber.Skip(2).Take(4).All(x => x >= '0' && x <= '9')
                && licensePlateNumber.Skip(6).Take(2).All(x => x >= 'A' && x <= 'Z');
        }
    }
}
