using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericsByBroCode50._49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generic -  anything generic is "not specific to a particular data type"
            //            you can make something generic by adding <T> to: classes, methods, fields, etc.(whatever we want)
            //            this allows for greater code reusability for different data types

            //lets create 3 arrays
            int[] intArray = { 1, 2, 3 };//elements arent important, but the data type is
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };
            //1..and display them
            //3
            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);
            //you'll notice we cant use this method for any data type other than integers.
            //you could add another method(s) to solve this issue, but what if we had a method that could accept any data type?
            //This is where generics come in handy...2

        }
        //lets create a method to display an array...1
        /*public static void displayElements(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }*/
        // 2 Lets create a generic method instead... 3
        public static void displayElements<T>(T[] array)// or you can switch "T" for "Thing" if you tryna be funny, but anyhting will do as long as it's consistent
        {
            foreach (T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
