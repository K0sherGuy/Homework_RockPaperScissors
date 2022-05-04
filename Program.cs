using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuChoice = rnd.Next(1, 4);

            Console.WriteLine("Rock, Paper, Scissors");
            string userChoice = Console.ReadLine().ToLower();

            while (true)
            {
                if (cpuChoice == 1)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("Computer: rock");
                        Console.WriteLine("draw!");
                        break;
                    }

                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("Computer: rock");
                        Console.WriteLine("player wins!");
                        break;
                    }

                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("Computer: rock");
                        Console.WriteLine("computer wins!");
                        break;
                    }
                }

                else if (cpuChoice == 2)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("Computer: paper");
                        Console.WriteLine("computer wins!");
                        break;
                    }

                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("Computer: paper");
                        Console.WriteLine("draw!");
                        break;
                    }

                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("Computer: paper");
                        Console.WriteLine("player wins!");
                        break;
                    }
                }

                else if (cpuChoice == 3)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("Computer: scissors");
                        Console.WriteLine("player wins!");
                        break;
                    }

                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("Computer: scissors");
                        Console.WriteLine("computer wins!");
                        break;
                    }

                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("Computer: scissors");
                        Console.WriteLine("draw!");
                        break;
                    }

                }
            }
        }
    }
}
