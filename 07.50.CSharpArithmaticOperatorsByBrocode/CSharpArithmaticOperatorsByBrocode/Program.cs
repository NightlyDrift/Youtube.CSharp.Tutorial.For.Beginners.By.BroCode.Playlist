using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArithmaticOperatorsByBrocode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lets look at a few examples of how to add to a variable value 
            //standard way
            int a = 5;
            a = a + 1;

            Console.WriteLine(a);

            //shorter way
            int b = 1;
            a += 1;
            Console.WriteLine(b);

            //found within boolean loops..
            int c = 1;
            c++;
            Console.WriteLine(c);

            /*other operators with the three similar denotations of standard short and boolean loop
             * Subtraction: 
             * numerical var or int a = 1
             * a = a + 1;
             * a -= 1;
             * a--;
             * 
             * Multiplication: 
             * numerical var or int a = 1
             * a = a * 2;
             * a *= 2;
             * not covered but is ** just multiplying by 1?
             * 
             * Division: 
             * numerical var or double a = 5
             * a = a / 2
             * a /= 2
             * again not covered but // might just be dividing by 1 so...
             * !Key thing here is the dividing an int will only work for results in whole numbers not real numbers so use a double or data type that allows decimals
             * 
             * Modulus:
             * Last operator is called the modulus operator (represented by %) 
             * aka the remainder operator to store the remainder of the division function
             * also pretty good for determining if numbers are even or odd too
             * Ex:
             */

            int d = 10;
            int remainder = d % 3; //this divides the value of d by 3 while indicating to store the remainder of the result in var int remainder
            Console.WriteLine(remainder);



        }
    }
}
