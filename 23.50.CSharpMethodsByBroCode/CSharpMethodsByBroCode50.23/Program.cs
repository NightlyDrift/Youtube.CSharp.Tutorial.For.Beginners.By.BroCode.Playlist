using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethodsByBroCode50._23
{
    internal class Program
    {
        static void Main(string[] args)// Main is a method
        {
            //method - performs a section of code whenver its "invoked"/called (so written...)
            //          which lets you reuse code without having ot rewrite it
            //for example lets sing happy b-day 3 times for someone...

            String name = "Bro";
            int age = 21;
            // We need to pass arguments (args) to the other method to be able to use this variable
            //To send args over to a method list whatever needs sending in the parentheseis method(var name) howver you need a matching set of args and parameters
            // multiple variables are seperated via ,
            singHappyBirthday(name,age);
            singHappyBirthday(name, age);
            singHappyBirthday(name, age);

            // parameters - a method needs parameters to receive to be invoked; what a method is expected to recieve 


        }
        // parameters - a method needs parameters to receive to be invoked; what a method is expected to recieve
        // aka declare variable in method like so... singHappyBirthday(String name, int age)
        // multiple variables are seperated via ,
        //variables declared in the reference method do not need to have the same name, what matters is the data type and order that you send args over when the method is invoked in main
        static void singHappyBirthday(String name, int age)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine($"Happy birthday to dear {name}!"); //methods do not automatically have access to variables declared within another method 
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine($"You are {age} years old.");



        }
    }
}
