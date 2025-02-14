using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpForLoopsByBroCode50._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Loop- repeats some code a finite amount of times unlike awhile loop
            //for example lets count to 10

            //the first part is the variable's starting value, second is the condition for the loop, & lastly the incrementation of value.
            //also i++ is short for i + 1, i+=2 would increase by 2 each time
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

            }


            //Now lets make a new years count down, -- like ++ just means it will change the value of the variable by 1
            for(int x = 10; x > 0; x--)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Happy New Year");


        }
    }
}
