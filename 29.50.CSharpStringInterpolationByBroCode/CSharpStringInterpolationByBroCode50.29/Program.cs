using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringInterpolationByBroCode50._29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String Interpolation - allows us to insert variables into a string literal
            //                        you precede a string literal with $
            //                        {} are placeholders

            // yeah so i already know this. uh... heres an example

            String fName = "Bro";
            String lName = "Code";
            int age = 21;

            Console.WriteLine($"{fName}{lName}");

            // but this is new...
            Console.WriteLine($"You are {age,-10} old.");
            //,-10 allocates spaces between age and "old" while postioning the variable on the left side of those spaces
            // positive allocation displays the variable after the spaces
            // just remember that the variable will take up spaces in which you are trying to allocate
            // so in this example where age is 21 allocating 10 spaces would mean there is only 8 actual spaces displayed as age value 21 takes 2 spaces to display
        }
    }
}
