using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEnumsByBroCode50._48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enum(s) -  a kind of special "class" that contains a grouping/set of named integer constants.
            //            Coders typically use enums when they have values that they know will not change,
            //            To get the integer value from an item, you must explicitly convert to an int
            //            name = integer
            //            name integer constants that will not change throughout the life of the program) 

            Console.WriteLine($"{Planets.Pluto} is a planet");

            Console.WriteLine($"{Planets.Mercury} is the {(int)Planets.Mercury} planet is our solar sytem");
            // "(int)Planets.Mercury" This will convert our named member into an integer to display
            Console.WriteLine($"{Planets.Pluto} is the {(int)Planets.Pluto} planet is our solar sytem");

            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine($"planet: {name}");
            Console.WriteLine($"radius: {radius} km");
            Console.WriteLine($"volume: {volume} km");





        }
        //CHALLENGE ROUND!!!
        // Lets create a way to display the volume of the planets
        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);// formula to find the volume of a sphere... i think i want to research this...
            return volume;

        }
    }
    //Placing all your names on the same line is possible, but more difficult to read
    // seperate names with commas except for the last name
    // by default the associated integer for each name going down the list starts with 0 (like arrays)
    // But you can change their integer values by setting different values "Mercury = 1," for example
    // unlike an array changing the integer value will not affect placement, in fact i dont know if thats even a functionality of enums
    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }
    // now lets do something a bit more complicated and create an enum to store the radius of each planet
    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}
