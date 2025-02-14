using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalOperatorsByBroCode50._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logical Operators - Used to check if more than 1 condition is true/false

            // && (and)
            // || (or)

            //For example lets determine if the outside temp is suitable to go outside

            Console.WriteLine("What's the british temperature outside?");
            double temp = Convert.ToDouble(Console.ReadLine()); 

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside");
            }
            else if(temp >= -50 || temp <= 50)
            {
                Console.WriteLine("Do not go outside!");
            }

            // This example is a little haphazard and isnt very specific also it doesnt use switches so im gonna try something...
            //Okay yeah... this doesnt work...
            /*Console.WriteLine("Hmm... What should I wear on my walk? What's the american temp outside?");
            double temp1 = Convert.ToDouble(Console.ReadLine());

            switch (temp1)
            {
                case < 15.0:
                    Console.WriteLine("Looks like shorts and t-shirt then");
                    break;


            }*/
               




        }
    }
}
