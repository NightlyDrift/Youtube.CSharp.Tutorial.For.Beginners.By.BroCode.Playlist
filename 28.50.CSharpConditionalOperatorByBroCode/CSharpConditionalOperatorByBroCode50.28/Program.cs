using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConditionalOperatorByBroCode50._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conditional operator - used in conditional assignment if a condition is true/false

            // Syntax - (condition) ? x : y 
            // conditional operator is represented by a ?, if true do x, if false do y

            double tempc = 20;
            String message;

            //what if we wwanted to display a custom message based on temp value with if statements?

            if(tempc >= 15)
            {
                message = "It's warm";

            }
            else
            {
                message = "It's cold";

            }
            Console.WriteLine(message);

            // one way to shorten this is with conditional operators...

            message = (tempc >= 15) ? "It's warm" : "It's cold";//because they are returning values they need to be assigned to a variable








        }
    }
}
