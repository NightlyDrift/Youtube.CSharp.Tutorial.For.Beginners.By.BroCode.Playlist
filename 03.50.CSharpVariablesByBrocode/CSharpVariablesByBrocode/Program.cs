using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVariablesByBrocode
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Variables (or var for c# speak) are containers for values. Some include:
             * Characters- char x = '!'
             * Words- String y = "Bro"
             * Booleans (True/False Statements)- bool z = true
             *
             *Creating a variable takes 2 steps:
             *1- Declaration
             *Declaring the type of data being stored. 
             *Ex: Numerical...
             */

            int x;//declaration

            /*2- Initialization (init for short)
              * Assigns a value to the variable.
              *Continuing ex...
              */

            x = 123;//initialization

            //These 2 steps to create a variable can be combined like so...

            int y = 321;//Declaration + Initialization

            int z = x + y;

            int age = 21;//Whole number/ integer

            double height = 300.5;//Decimal number

            bool alive = true;//True or False status

            char symbol = '@';//A single character, two or more characters cause an error

            String name = "Bro";

            String userName = symbol + name;



            //The first two above variables (x,y) display as the values they contain. Lets display them...

            Console.WriteLine(x);
            Console.WriteLine(y);


            //We can also use these variables to perform some simple math functions for example (see variable z above the previous code)...

            Console.WriteLine(z);

            // Variables x,y,z arent very descriptive. We could give more unique names to the values these variables contain. For example see age variable below variable Z above...
            //You can also display a message along with your variable like so...

            Console.WriteLine("Your age is " + age);

            // Another way of coding this statement would be as follows...

            Console.WriteLine($"Your age is {age}");

            /*But there are more data types than int
             * While int can only store whole integers/ numbers such as 21,1,2,3,4,5,6,7,8,9,0,236401723, etc.
             * double can store decimals numbers like 300.5 as seen below int age...
             * "It's like a floating point number, but with more pricision. There are floats in c sharp but I dont think they're really that iomportant for beginners"
             * Lets dsiplay a double using another way of showing these values kinda like the first way... 
             */

            Console.WriteLine("Your height is " + height + " cm");

            // Again this can also be written as...

            Console.WriteLine($"Your height is {height} cm");

            /* The next data tyoe is boolean or bool. they can only store true or false values which can be useful for scenarios with only two outcomes.
             * See example of boolean value under double variable above...
             * Now lets use this variable below...
             */

            Console.WriteLine("Are you alive? " + alive);
            //or
            Console.WriteLine($"Are you alive? {alive}");

            /* The next data type is char. It can store a single character. See below bool alive variable above...
             * Lets display it...
             */

            Console.WriteLine("Your symbol is: " + symbol);
            //or 
            Console.WriteLine($"Your symbol is: {symbol}");

            /* While char can only store a single character a string can store multiple characters.
             * See variable below char symbol above...
             * as always how to disolay shown below...
             */

            Console.WriteLine("Hello " + name);
            //or
            Console.WriteLine($"Hello {name}");

            //Now lets say this person has a username on some site idk. See ex below previoud variable mentioned above and how its displayed below

            Console.WriteLine("Your username is: " + userName);
            // or
            Console.WriteLine($"Your username is: {userName}");


            Console.ReadKey();
        }
    }
}
