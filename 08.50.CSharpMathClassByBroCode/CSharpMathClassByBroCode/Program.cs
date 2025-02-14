using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMathClassByBroCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x = 3;
            double y = 3.14;
            double z = 3.99;

            //Math.Pow takes the numerical value of a and gives it a power of 2 and displays it via the command below
            double a = Math.Pow(x,2);

            // Math.Sqrt square root's the numerical value of x
            double b = Math.Sqrt(x); 

            //Math.Abs finds the absolute value of x. Absolute value is how far the number is off from zero.
            //meaning negative numbers are turned into positive ones
            double c = Math.Abs(x); 

            //Math.Round rounds the numerical value of y to a whole number
            double d = Math.Round(y);

            //Math.Ceiling rounds the numerical value of y up to the nearest whole number regardless on if the number's decimal value is close to it or not 
            double e = Math.Ceiling(y);

            //Math.Floor is like the reverse of math.ceiling. it will round down to the lowest integer regardless of the decimal value
            double f = Math.Floor(z);

            //Math.Max will find which variable has the highest numerical value and use that value
            double g = Math.Max(y, z);

            //Math.Min, like max will find which variable has the lowest numerical value and use that value
            double h = Math.Min(y, z);


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);

        }
    }
}
