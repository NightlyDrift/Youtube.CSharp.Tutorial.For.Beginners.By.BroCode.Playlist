using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWhileLoopsByBroCode50._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While loop- repeats some code while some condition remains true

            Console.WriteLine("Enter your name:");
            String name = Console.ReadLine();

            // Be careful not to write conditions that will always be true otherwise the program will be stuck in an infinite loop.
            while (name == "") // if this was while (1 == 1) then it would be considered an inifinite loop as there would be no way to change the condition
            {
                Console.WriteLine("Null entry detected. Please enter your name");
                name = Console.ReadLine();
            }

            Console.WriteLine($"See that was simple wasnt it {name}?");



        }
    }
}
