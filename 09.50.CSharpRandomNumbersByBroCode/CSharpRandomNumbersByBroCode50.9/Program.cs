using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRandomNumbersByBroCode50._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //not truly random, but close
            Random random = new Random(); //This looks like an object defined within the default system namespace...
            //theres a few built in methods of this random object...
            //.Next will generate a random whole integer between 0 and just over 2bil so we probably need to set a range
            //using 1 as out minumum value and 7 as our max this will generate a random number between 1 and 6 like a 6 sided dice
            //"because this second number will technically be exclusive"
            int num = random.Next(1, 7);
            //This line of code can also be adjusted for example...
            int num2 = random.Next(1, 7) + 100;

            //Now theres is also nextdouble which will generate a psuedorandom decimal number between 0 and 1
            double num3 = random.NextDouble();
            //while this command doesnt allow you to generate a decimal number past the value of .99 repeating it could be added onto a random whole number to the same effect

            //if you want to generate multiple random numbers the code will need to be entered in multiple times
            
            Console.WriteLine(num);
            
            Console.WriteLine(num2);

            Console.WriteLine(num3);



        }
    }
}
