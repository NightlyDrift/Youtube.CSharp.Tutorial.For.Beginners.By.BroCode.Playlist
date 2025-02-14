using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRockPaperScissorsGameByBroCode50._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player; //just noticed String & string are different. stack overflow suggests using string for objects and String to refer to the class 
            String computer;
            String answer;

            while (playAgain = true)
            {
                player = "";
                computer = "";
                answer = "";



                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Rock, Paper, Scissors!");
                    player = (Console.ReadLine());
                    player = player.ToUpper();
                }
                // int randNum = random.Next(1, 4); this would work too just more work to write this and insert var in the switch
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine(" ");
                Console.WriteLine($"Computer chose...{computer}");
                Console.WriteLine("");
                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("DRAW!");

                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("YOU LOSE!");
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("DRAW!");

                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("YOU LOSE!");
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("DRAW!");

                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU LOSE!");
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        break;
                }
                Console.WriteLine("PLAY AGAIN? (Y/N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                switch (answer)
                {
                    case "Y":
                        playAgain = true;
                        break;
                    case "N":
                        playAgain = false;
                        Console.WriteLine("Sounds good, Thanks for playing!");
                        break;
                }
            }
        }
    }
}
