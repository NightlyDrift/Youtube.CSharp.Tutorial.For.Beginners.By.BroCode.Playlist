using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAbstractClassesByBroCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstract - a keyword that can be applied to classes, properties, and methods 
            // but this will focus on classes
            // Abstract Classes - modifier that indicates missing components or incomplete implementation

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            
            Vehicle vehicle = new Vehicle();
            // Adding abstract to the class, you can't create a vehicle object by itself
            // Adding a bit of security by not allowing instantiation of a specific class
            // Useful for not allowing instantion of a class that relies on child classes for missing components or incomplete implementation
            // You dont want someone to pick the invisible car in a race lol

            Console.ReadKey();
        }
    }
    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving.");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}
