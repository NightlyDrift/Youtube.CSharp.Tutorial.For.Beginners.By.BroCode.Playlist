using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToStringMethodByBroCode50._41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ToString() - an inherent method of objects whose task is to convert an object to it's string representation so that it's suitable to display

            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car.ToString()); //normally this would display the namespace and the type of object, but we can overrride this tostring method
            //or... 
            Console.WriteLine(car);
            //will do the same thing because it will call the tostring method behind the scenes
        }
    }
    class Car
    {
        String make; // fields
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color) // constructor
        {
            this.make = make; //assigning fields
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
            // return base.tostring(); might autogenerate upon completion of this line of codeto return base to string
            // , but we can return a string representation more suitable to display...
        {
            String message = "This is a " + make + " " + model;
            //or
            return "This is a " + make + " " + model;
        }
    }
}
