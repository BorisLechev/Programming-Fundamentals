namespace _1._1.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string pattern = @"\b(?<=\s|^)[A-Za-z\d]+[A-za-z\d-_.]*@[a-z]+[a-z.-]*\.[a-z.-]+\b";
            var mails = Console.ReadLine();

            var regex = Regex.Matches(mails, pattern);

            foreach (var item in regex)
            {
                Console.WriteLine(item);
            }
        }
    }
}
