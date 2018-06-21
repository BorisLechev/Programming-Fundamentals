namespace _3.LastKNumbersSumsSequence
{
    using System;

    public class LastKNumbersSumsSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var sequence = new int[n];

            sequence[0] = 1;

            //тоест първият елемнт започва от 1, 
            for (int i = 1; i < n; i++) // преди 1 имаш "0"-> 0 0 1 , събираш ги и 0 + 0 + 1 = 0 1 1->
                                        //1 1 2 -> 1 1 2 4 -> 1 1 2 4 7 -> 1 1 2 4 7 13
            {
                int sum = 0;

                for (int prev = i - k; prev <= i - 1; prev++)
                {
                    if (prev >= 0)
                    {
                        sum += sequence[prev];
                    }

                    sequence[i] = sum;
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
