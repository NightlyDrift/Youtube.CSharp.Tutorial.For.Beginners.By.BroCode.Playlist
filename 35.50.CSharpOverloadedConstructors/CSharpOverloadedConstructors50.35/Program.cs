using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverloadedConstructors50._35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Overloaded Constructors - a technique to create multiple contructors within the same class 
            //                           like overloaded methods they can have the same name, but different parameters to create a unique signature
            //                           similar name + different param = unique signature

            Pizza pizza = new Pizza("stuffed crust", "marinara", "mozzerella", "pepperoni");
            Pizza pizza = new Pizza("stuffed crust", "marinara", "mozzerella");

        }
    }
    class Pizza // class
    {
        String bread; //fields
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
        // if you wanted a pizza that had no toppings you will need to create a new construct like so...
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
    }
}
