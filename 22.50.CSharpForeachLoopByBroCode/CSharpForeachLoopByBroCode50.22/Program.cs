using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpForeachLoopByBroCode50._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // foreach loop - simple way (less to type) to iterate each value in an array, but less flexible
            
            String[] cars = { "BMW", "Mustang", "Corvette" };

            //for loops allow for more customization via i+=,-=,++,--, etc
            for (int i = 0; i < cars.Length; i++) 
            {
                Console.WriteLine(cars[i]);
            }
            //example of a foreach loop...
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
            // my take is booooooooo shortcuts for losers
            // if you needed to go back and customize it then why not take the extra time to write a for loop?


        }
    }
}
