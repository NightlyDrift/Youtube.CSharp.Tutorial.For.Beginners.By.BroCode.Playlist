using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReturnKeywordByBroCode50._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Return - keyword that returns data back to where the method is invoked
            //for example lets create a method that multiplies two numbers

            double x;
            double y;
            double result;

            Console.WriteLine("First Value is...");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second Value is...");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);
            Console.WriteLine(result);

        }

        static double Multiply(double x, double y)// void is changed to double because you need to change void to the data type being returned
        {

            double z = x * y;
            return z;
            // return z = x * y; would work the same too

        }





    }
}
