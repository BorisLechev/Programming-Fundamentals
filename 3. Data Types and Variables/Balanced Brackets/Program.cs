using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Brackets // !!!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            string brackets = string.Empty;
            string result = "BALANCED";
            for (int i = 0; i < numberOfLines; i++)
            {
                string str = Console.ReadLine();
                if (str == ")" || str == "(")
                {
                    brackets += str;
                }
            }
            if (brackets.Length % 2 == 1)
            {
                result = "UNBALANCED";
            }
            for (int j = 0; j < brackets.Length; j++)
            {
                if (j % 2 == 0 && brackets[j] == ')')
                {
                    result = "UNBALANCED"; break;
                }
                if (j % 2 == 1 && brackets[j] == '(')
                {
                    result = "UNBALANCED"; break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
