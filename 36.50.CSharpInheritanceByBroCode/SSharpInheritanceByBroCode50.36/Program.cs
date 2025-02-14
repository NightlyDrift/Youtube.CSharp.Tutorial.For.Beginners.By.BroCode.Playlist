using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSharpInheritanceByBroCode50._36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance - concept of 1 or more child classes recieving fields, methods, etc from a common parent
            //               useful to reuse code, you can keep anything the classes have in commmon in a common parent class


            Car car = new Car(); //instatiating classes
            Bike bike = new Bike();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bike.speed);
            Console.WriteLine(bike.wheels);
            bike.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();



        }
    }
    class Vehicle
    {
        public int speed = 0;


        public void go()
        {
            Console.WriteLine("This vehicle is mmoving.");

        }

    }
    // We can inherit the above go method and speed field from the vehicle class into another class by using : and the name of the parent class like so...

    class Car : Vehicle
    {
        public int wheels = 4; 

    }
    class Bike : Vehicle
    {
        public int wheels = 2;

    }
    class Boat : Vehicle
    {
        public int wheels = 0;

    }
}
