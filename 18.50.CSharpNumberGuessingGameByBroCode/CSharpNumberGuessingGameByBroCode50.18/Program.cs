using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNumberGuessingGameByBroCode50._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while(playAgain) //Could also be written as playAgain == true, but since its a bool variable this will also work
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);
                    
                while(guess != number)
                {
                    Console.WriteLine($"Guess a random number between {min} and {max}");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is too high...");
                    }
                    else if(guess<number)
                    {
                        Console.WriteLine($"{guess} is too low...");
                    }
                    guesses++;
                }
                Console.WriteLine($"{number}...IS CORRECT!");
                Console.WriteLine("You got it!");
                Console.WriteLine($"It only took you {guesses} times.");
                Console.WriteLine("...");
                Console.WriteLine("Want another go at it? (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Sounds good, thanks for playing!");
        }
    }
}
