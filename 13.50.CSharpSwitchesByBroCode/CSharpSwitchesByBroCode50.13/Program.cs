using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSwitchesByBroCode50._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch- an efficient alternative to writing many else if statements
            // a few else if statements can be okay but more than that is excessive and will get you called a noob
            //so lets use a switch instead

            Console.WriteLine(" ");
            Console.WriteLine("What day of the week is it today?");
            Console.WriteLine(" ");
            String day = Console.ReadLine();

            switch (day) //this will examine the day variable against the many cases listed within the switch statement
            {
                case "Monday": //case will define a specific value to compare the variable defined in the switch kind of like an else if
                    Console.WriteLine("It's Monday?");
                    break; //break will exit the switch
                case "Tuesday": 
                    Console.WriteLine("It's Tuesday?");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday?");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday?");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday?");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday?");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday?");
                    break;
                default: //for when there are no matching cases for the var defined in switch 
                    Console.WriteLine(day + " is not a day!");
                    break;





            }





        }
    }
}
