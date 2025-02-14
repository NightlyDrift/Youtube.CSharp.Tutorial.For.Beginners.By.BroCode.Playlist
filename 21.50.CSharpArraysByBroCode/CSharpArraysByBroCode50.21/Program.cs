using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArraysByBroCode50._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array - Avariable that can store multiple values. fixed size
            
            //to declare a fixed size of the array you would write...
            String[] cars = new string[3]; 
            //while an array declares values starting at zero the same rule does not apply when declaring fixed size
            //also if a value in an array is declared and left undefined it will register as nothing when utilized
            
            //and then declare the values of the array like so...
            cars[0] = "BMW";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            //String car = "BMW"; ex of a string variable
            /*String[] cars = { "BMW", "Mustang", "Corvette" };*/
            
            // Console.WriteLine(cars); will not work as you need to specify which value will be displayed like so...
            Console.WriteLine(cars[0]);//computers always start with 0, so 0 would correlate to the first value in the array (BMW)
            Console.WriteLine(cars[1]); 
            Console.WriteLine(cars[2]);// if this was a 3 and there is no 4th value in the array an error will occur saying this was out of bounds of the array

            //To update a value in the array you would write...
            cars[0] = "Tesla";// with brackets after the variable to specify which value you want to chnage. in this case BMW to Tesla
            Console.WriteLine(cars[0]);

            // An easier way of displaying all vlaues in an array is by using a for loop
            for (int i = 0; i < cars.Length; i++) // the length property will get the total number of values in the array
            {
                Console.WriteLine(cars[i]);// as the for loop increases i's value the array value being displayed will change according to the position described by i
            }




        }
    }
}
