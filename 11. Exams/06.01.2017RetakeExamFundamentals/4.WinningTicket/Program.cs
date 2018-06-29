namespace _4.WinningTicket
{
    using System;
    using System.Linq;

    public class WinningTicket
    {
        public static void Main()
        {
            var inputTickets = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var output = new string[inputTickets.Length];
            char[] winningSymbols = { '@', '#', '$', '^' };

            for (int i = 0; i < inputTickets.Length; i++)
            {
                string currentTicket = inputTickets[i];

                if (currentTicket.Length != 20)
                {
                    output[i] = "invalid ticket";
                }

                else
                {
                    char currentCharLeft = currentTicket[0];
                    int countInRowLeft = 0;
                    bool winningLeft = false;

                    for (int j = 0; j < 10; j++)
                    {
                        if (currentCharLeft == currentTicket[j])
                        {
                            countInRowLeft++;
                        }

                        else if (!winningLeft)
                        {
                            countInRowLeft = 1;
                            currentCharLeft = currentTicket[j];
                        }

                        if (countInRowLeft >= 6)
                        {
                            winningLeft = true;
                        }
                    }

                    if (winningLeft && winningSymbols.Contains(currentCharLeft))
                    {
                        char currentCharRight = currentTicket[currentTicket.Length - 1];
                        int countInRowRight = 0;
                        bool winningRight = false;

                        for (int k = currentTicket.Length - 1; k >= 10; k--)
                        {
                            if (currentCharRight == currentTicket[k])
                            {
                                countInRowRight++;
                            }

                            else if (!winningRight)
                            {
                                countInRowRight = 1;
                                currentCharRight = currentTicket[k];
                            }

                            if (countInRowRight >= 6)
                            {
                                winningRight = true;
                            }
                        }

                        if (winningRight && winningSymbols.Contains(currentCharRight))
                        {
                            int lengthChars = countInRowLeft > countInRowRight ?
                                countInRowRight : countInRowLeft;

                            if (countInRowLeft == 10 && countInRowRight == 10)
                            {
                                output[i] = $"ticket \"{ currentTicket}\" - {lengthChars}{currentCharRight} Jackpot!";
                            }

                            else
                            {
                                output[i] = $"ticket \"{currentTicket}\" - {lengthChars}{currentCharRight}";
                            }
                        }

                        else
                        {
                            output[i] = $"ticket \"{currentTicket}\" - no match";
                        }
                    }

                    else
                    {
                        output[i] = $"ticket \"{currentTicket}\" - no match";
                    }
                }
            }

            foreach (var printAnswer in output)
            {
                Console.WriteLine(printAnswer);
            }
        }
    }
}
