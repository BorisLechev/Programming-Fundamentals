namespace _3.PhoenixGrid
{
    using System;
    using System.Text.RegularExpressions;

    public class PhoenixGrid
    {
        public static void Main()
        {
            string input = string.Empty;
            string pattern = @"^([^\s_]{3}\.)+([^\s_]{3})$";  

            while ((input = Console.ReadLine()) != "ReadMe")
            {
                var match = Regex.Match(input, pattern);

                if (match.Success || input.Length == 3)  //if (pattern.IsMatch(input) || input.Length == 3)
                {
                    bool isPalindrome = true;

                    for (int i = 0; i < input.Length / 2; i++)
                    {
                        if (input[i] != input[input.Length - 1 - i])
                        {
                            isPalindrome = false;
                            Console.WriteLine("NO");
                            break;
                        }
                    }

                    if (isPalindrome)
                    {
                        Console.WriteLine("YES");
                    }
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
