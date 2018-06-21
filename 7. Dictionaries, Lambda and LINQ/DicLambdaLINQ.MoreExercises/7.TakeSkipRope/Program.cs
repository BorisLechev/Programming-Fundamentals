namespace _7.TakeSkipRope
{
    using System;
    using System.Linq;

    public class TakeSkipRope
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var numbersList = input.Where(x => char.IsDigit(x)).Select(x => int.Parse(x.ToString())).ToList();
            var nonNumbers = input.Where(x => !char.IsDigit(x)).ToList();

            var takeList = numbersList.Where((digit, index) => index % 2 == 0).ToList();
            var skipList = numbersList.Where((digit, index) => index % 2 == 1).ToList();

            string result = string.Empty;
            int totalSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                var skip = skipList[i];
                var take = takeList[i];
                string currentResult = new string(nonNumbers.Skip(totalSkip).Take(take).ToArray());
                result = string.Concat(result, currentResult);
                totalSkip += skip + take;
            }

            Console.WriteLine(result);
        }
    }
}
