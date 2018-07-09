namespace _3.Wormhole
{
    using System;
    using System.Linq;

    public class Wormhole
    {
        public static void Main()
        {
            var wormholes = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int counter = 0;
            int oldValue = 0;

            for (int i = 0; i < wormholes.Count; i++)
            {
                if (wormholes[i] != 0)
                {
                    oldValue = wormholes.IndexOf(wormholes[i]);
                    i = wormholes[i];
                    wormholes[oldValue] = 0;
                }

                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
