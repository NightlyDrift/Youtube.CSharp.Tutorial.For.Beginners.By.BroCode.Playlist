using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUserInputByBrocode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The following shows how to accept user input via the command console.readline without accounting for exceptions (aka data not fit for data type)
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine(); 
            
            // brocode is writing variables like this as one line of code but the variable could be declared earlier on and then asked to be defined later on like so...

            String favColor;
            Console.WriteLine("What is your favorite color?");
            favColor = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            //or 
            Console.WriteLine($"Hello {name}");

            Console.WriteLine("You are " + age + "years old");
            //or
            Console.WriteLine($"You are {age} years old");

            //for personal alt example...
            Console.WriteLine("Your fav color is " + favColor);
            //or
            Console.WriteLine($"Your fav color is {favColor}");

        }
    }
}
