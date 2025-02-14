using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIfStatementByBroCode50._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if statement - a basic form of decision making where if a value equals something or not the program will execute certain code
            // For example lets write a program determining if the user is old enough for a credit card
            Console.WriteLine("Welcome to Shark Credit Services!");
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100)
            {
                Console.WriteLine("You're too old to sign up");
            }
            /*else - statement must be after else if otherwise an error will occur
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }
            */
            //Values must be assigned in order of execution
            //since the program will also run top to bottom the age requirement needs to be in an if else statment for 100+ statment to work correctly
            else if (age < 0)
            {
                Console.WriteLine("You must be alive to sign up!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You're now signed up!");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }



            //Example: checking for null string data though something tells me this could be a case for tryparse
            
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            
            //There are two ways to write this with the two comparision operators
            // == checks if a variable equals a value while != check if a variable does not equal a value
            if (name == "")
            {
                Console.WriteLine("You didn't enter a name...");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }
            
            if (name != "")
            {
                Console.WriteLine("Hello " + name);
            }
            else 
            {
                Console.WriteLine("You didn't enter a name...");
            }




        }
    }
}
