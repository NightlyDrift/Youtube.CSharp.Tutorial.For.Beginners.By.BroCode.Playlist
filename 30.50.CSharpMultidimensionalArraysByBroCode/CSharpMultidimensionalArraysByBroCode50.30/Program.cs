using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMultidimensionalArraysByBroCode50._30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Multidimensional Array - An array of arrays
            // useful to make a grid or matrix of data (sounds like excel to me)

            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyota = { "Corolla", "Camry", "Rav4" };

            //Example of a 2 dimiensional (2D) array...
            //String[,] parkingLot = { { "Mustang", "F-150", "Explorer" }, { "Corvette", "Camaro", "Silverado" }, { "Corolla", "Camry", "Rav4" } };
            // Can be Written as... for aethetics
            String[,] parkingLot = {                                        //Multi-d arrays and values always start with 0     
                                    { "Mustang", "F-150", "Explorer" },     // row: 0  value: 0,1,2
                                    { "Corvette", "Camaro", "Silverado" },  // row: 1  value: 0,1,2
                                    { "Corolla", "Camry", "Rav4" }          // row: 2  value: 0,1,2
                                    };
            // you can specify the selected value by using rows and values like a vending maching. for example row 0 value 2 would be Explorer
            // lets replace Explorer with a fusion...
            parkingLot[0, 2] = "Fusion";
            // now lets replace corolla with a tacoma
            parkingLot[2, 0] = "Tacoma";
            // and display the values
            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }
            //but the above code doesnt display these values in a grid. you need a nested for loop for that..
            // 0 is the value of the dimension (think height and width for 2d array) you will display. this also starts at 0
            for (int i =  0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write($"{parkingLot[i, j]} ");
                }
                Console.WriteLine(" ");// this tabs to the next row
            }




        }
    }
}
