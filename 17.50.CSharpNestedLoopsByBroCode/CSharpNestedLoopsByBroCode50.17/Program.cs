﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNestedLoopsByBroCode50._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nested Loops - loops inside ither loops, loopception
            //                Uses Vary. Used a lot in sorting algorithims
           
            //In this example we'll create a rectangle made of characters
            Console.Write("How many rows?");
            int rows = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("How many Columns?");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What Symbol?");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(symbol);
            }
        }
    }
}
