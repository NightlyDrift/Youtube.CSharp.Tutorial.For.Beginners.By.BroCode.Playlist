using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstantsByBroCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constants are immutable values which are known at compile time and don't change for the life of the program
            
            //While this code will update x's value to 2...
            double x = 1;
            x = 2;

            //This will insure the value is set and will not change...
            const double y = 1; 

            //no other information about utilization was provided.
            //while constants are not variables it acts as a variable modifier preceding the variable.
            // no idea how this is useful yet


        }
    }
}
