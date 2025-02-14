using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethodOverloadingByBroCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method overloading - methods can share the name name, but need a different set of parameters
            // this is because methods must have a unique signature which is made of both name and parameters...
            //name + parameters = signature
            //so in this example it looks like the number of values determines the method being used
            double total;

            total = Multiply(2, 3, 4);
            Console.WriteLine(total);

        }
        static double Multiply (double a, double b)
        {

            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {

            return a * b * c;
        }
    }
}
