using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParamsKeywordByBroCode50._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Params Keyword - a method that takes a variable number of arguments
            //                  The Parameter type must be a single - dimensional array (no idea but something tells me this may be about data types
            // useful for when you're unsure how many arguements are going to need to be passed over

            double total;

            total = CheckOut(2, 3, 4);
            Console.WriteLine(total);

        }
        static double CheckOut(params double[] prices)//[] prices declares an array
        {
            double totalLV = 0;// since this is a different method similar names of variables in other methods can be used as locla variables, sounds confusing tho.
            foreach(double price in prices)
            {
                totalLV += price;
            }
            return totalLV;
        }



    }
    }
}
