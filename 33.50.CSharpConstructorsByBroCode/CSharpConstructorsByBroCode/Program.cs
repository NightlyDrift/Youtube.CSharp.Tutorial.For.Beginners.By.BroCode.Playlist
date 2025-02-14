using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructorsByBroCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor - a special method found within a class
            //              it has the same name as the class name
            //              Can be used to assign arguments to fields when creating an object
            // classes missing a constructor are given a basic hidden constructor that is used to create objects

            Car car1 = new Car("Red", 2022, "Ford", "Mustang");
            Car car2 = new Car("Blue", 2022, "Chevy", "Corvette");

            car1.drive();
            car2.drive();

        }
    }
    class Car
    {
        String color;
        int year;
        String make;
        String model;

        // This is the constructor. It will have the same name as the class.
        // Considered a "special kind of method" where you can set up methods and parameter
        public Car(String color, int year, String make, String model) // so when it recieves args you can assign them to the variables above like so...
        {
            this.color = color;
            this.year = year;
            this.make = make;
            this.model = model;
        }

        //lets create a drive method to display the car being driven...
        public void drive()
        {
            Console.WriteLine($"You drive a {color}{year} {make} {model}");
        }


    }
}
