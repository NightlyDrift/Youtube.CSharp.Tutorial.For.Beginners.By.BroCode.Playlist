using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStaticByBroCode50._34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static - a modifier to declare a static member of the class itself instead of any specific object
            // look so my brain just does not want to even try to make sense of this video the guy is using words he hasnt gone over before and im just like ...
            // ig static just means isolated in a way? im gonna need to revisit this later
            // instatiate - the process of creating an object from a class

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");

            Console.WriteLine(Car.numberOfCars);
            //Console.WriteLine(car2.numberOfCars); this wont work because it'll just list the number of cars 1 at a time and not incrment
            //so instead were using the syntax above it to count the cars(no idea why we needed strings for this to work tho)
            Car.drive();


        }
    }
    class Car
    {
        String model;//fields - defining characteristics of what an object has, here we are declaring but not assigning a value
        public static int numberOfCars;  // field

        public Car(String model)// constructor
        {
            this.model = model;
            numberOfCars++;
        }

        public static void drive()// method
        {
            Console.WriteLine("RACE START!");
        }


    }
}

