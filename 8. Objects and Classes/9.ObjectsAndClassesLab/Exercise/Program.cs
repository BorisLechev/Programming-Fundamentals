using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace Exercise
{
    public class Country
    {
        public string CountryName { get; set; }
        public List<Town> Towns { get; set; }

        public Country(string name)
        {
            this.CountryName = name;
            this.Towns = new List<Town>();
        }
    }
    public class Town
    {
        public string TownName { get; set; }
        public List<Street> Streets { get; set; }

        public Town(string name)
        {
            this.TownName = name;
            this.Streets = new List<Street>();
        }
    }

    public class Street
    {
        public string StreetName { get; set; }
        public List<int> Numbers { get; set; }

        public Street(string name)
        {
            this.StreetName = name;
            this.Numbers = new List<int>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string ,Country> world = new Dictionary<string, Country>();

            Country country = new Country("Bulgaria");

            world.Add(country.CountryName, country);

            world["Bulgaria"].Towns.Add(new Town("Sofia"));
            world["Bulgaria"].Towns.First(t => t.TownName == "Sofia").Streets.Add(new Street("Tintyava"));
            world["Bulgaria"].Towns.First(t => t.TownName == "Sofia")
                .Streets.First(s => s.StreetName == "Tintyava").Numbers.Add(10);

            var sorted = world.OrderByDescending(c =>
            {
                int sum = 0;
                var towns = c.Value.Towns;

                foreach (var town in towns)
                {
                    foreach (var street in town.Streets)
                    {
                        street.Numbers.Sum();
                    }
                }

                return sum;
            });
        }
    }
}
