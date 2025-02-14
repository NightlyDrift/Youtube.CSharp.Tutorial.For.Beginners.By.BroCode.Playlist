using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypeCastingByBroCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Type Casting (conversion)- is the abilty to convert a value to a different data type.
             * It's useful when accepting user input because different data types do different things.
             * Ex:
             */

            double a = 3.14;
            int b = Convert.ToInt32(a); //as you can see in console this command converts var double a to an int and represents it as b and in doing so only displaying a whole number 

            //(1:
            int c = 123;
            double d = Convert.ToDouble(c);
            double z = Convert.ToDouble(c) + 0.1;

            //(2
            int e = 321;
            String f = Convert.ToString(e);

            //(3
            String g = "$";
            char h = Convert.ToChar(g);

            //4
            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine("Displaying variable a...");
            Console.WriteLine(a);
            Console.WriteLine("Displaying variable b...");
            Console.WriteLine(b);


            //It's also possible to display the var type your working with like so...

            Console.WriteLine("variable a data type is...");
            Console.WriteLine(a.GetType());
            Console.WriteLine("variable b data type is......");
            Console.WriteLine(b.GetType());
            Console.WriteLine("variable c data type is...");
            Console.WriteLine(c.GetType());
            Console.WriteLine("variable d data type is...");
            Console.WriteLine(d.GetType());
            Console.WriteLine("variable z data type is...");
            Console.WriteLine(z.GetType());
            Console.WriteLine("variable e data type is...");
            Console.WriteLine(e.GetType());
            Console.WriteLine("variable f data type is...");
            Console.WriteLine(f.GetType());
            Console.WriteLine("variable g data type is...");
            Console.WriteLine(g.GetType());
            Console.WriteLine("variable h data type is...");
            Console.WriteLine(h.GetType());
            Console.WriteLine("variable i data type is...");
            Console.WriteLine(i.GetType());
            Console.WriteLine("variable j data type is...");
            Console.WriteLine(j.GetType());

            //Now lets convert an int to a double using variables c, d, and z defined above(1...

            Console.WriteLine("Displaying variable c...");
            Console.WriteLine(c);
            Console.WriteLine("Displaying variable d...");
            Console.WriteLine(d);
            Console.WriteLine("Displaying variable d +.01...");
            Console.WriteLine(d + 0.1);
            Console.WriteLine("Displaying variable z...");
            Console.WriteLine(z);

            //Now lets convert an int to a string using variables e and f defined above(2...

            Console.WriteLine("Displaying variable e...");
            Console.WriteLine(e);
            Console.WriteLine("Displaying variable f...");
            Console.WriteLine(f);

            //Now lets convert a string to a char using variables g and h defined above(3...

            Console.WriteLine("Displaying variable g...");
            Console.WriteLine(g);
            Console.WriteLine("Displaying variable h...");
            Console.WriteLine(h);

            //Now lets convert a string to a boolean using variables i and j as defined above(4...

            Console.WriteLine("Displaying variable i...");
            Console.WriteLine(i);
            Console.WriteLine("Displaying variable j...");
            Console.WriteLine(j);


            Console.ReadKey();
        }
    }
}
