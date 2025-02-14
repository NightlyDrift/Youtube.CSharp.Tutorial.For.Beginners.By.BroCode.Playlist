using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExceptionHandlingByBroCode50._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exception - an error that occurs during execution (exe)
            //
            // try      - tries some code that's considered "dangerous" or may cause an exception
            // catch    - catches and handles specific exceptions when they occur
            // finally  - (optional) always executes regardless if an exception is caught or not
            //          - typically used for closing any open files, if you need to reset anything, etc.

            double x;
            double y;
            double result;

            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("---Simple Division Calculator---");
                Console.WriteLine(" ");

                Console.WriteLine("First Value:");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("Second Value");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" ");

                result = x / y;
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("-Please enter a numerical value-");
            }
            catch (DivideByZeroException e)//only occurs with integer division (double / 0 = ∞)
            {
                Console.WriteLine("-You cannot divide by 0-");
            }

            // this is a catch all block, it's not considered good practice to use a catch all block by itself.
            // it's useful for situations the programmer has yet to anticipate
            catch (Exception e)
            {
                Console.WriteLine("-Something went wrong-");
            }
            //
            finally
            {
                Console.WriteLine("Thanks for divisioning!");
            }
            
            
        }
    }
}
