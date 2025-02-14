using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpListsByBroCode50._44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List - a data structure that represents  a list of objects that can be accessed by index.
            //        Similar to array, but they can dynamically increase/decrease in size during runtime (which arrays cannot do)
            //        While using a list is more beneficial for when the amount of index places is uncertain one downside of this functionality is the increased memory usage
            //        utilizes namespace: System.Collections.Generic;



            //lets start with a standard array and try to add another element outside the index value of the array 
            /*String[] food = new string[3];

            food[0] = "pizza";
            food[1] = "burger";
            food[2] = "hotdog";
            food[3] = "fries";// this will cause an index out of range exception.

            foreach(String item in food)
            {
                Console.WriteLine(item);
            }
            // this is why using lists can be more beneficial for when the amount of elements within the index is uncertain.
            */
            List<String> food = new List<String>();

            food.Add("fries");
            food.Add("pizza");// to add elements to the index we used the built in add method
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //another benefit of lists is functionality of the built in remove method...
            food.Remove("Fries");
            //more useful methods include...
            food.Insert(0, "Sushi");// 0 indicates element place and to the right is the value were replacing with
            Console.WriteLine(food.Count);// count is a property which will represent the current size of the list
            Console.WriteLine(food.IndexOf("Pizza"));// IndexOf method finds the zero based place of a certain element value
            Console.WriteLine(food.LastIndexOf("Fries"));//LastIndexOf method finds the last time and zero based place of a certain element value
            Console.WriteLine(food.Contains("Pizza"));//Contains method checks the list to see if a certain value is contained within the list of elements (within the index) and return a boolean (true/false) value
            food.Sort(); // The Sort method will sort the element values within the list/index alphabetically
            food.Reverse(); //The Reverse method wil/ sort the element values within the list/index in reverse
            food.Clear(); // the clear method will clear or delete all elemental values within the index/list
            String[] foodArray = food.ToArray(); // the to ToArray method will convert a list into a array

            Console.WriteLine(food[0]);// accessing element values within the index is the same as in an array

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }



        }
    }
}
