using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPolymorphismByBroCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism - in coding this concept is described as when objects can be identified by more than one type
            //                EX: Dog is also a canine, animal, and organism
            // (greek word meaning "many forms")
            // Lets use the example of a race between multiple forms of transportation...

            Car car = new Car(); //instanting multiple objects
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // while "Vehicle" was "Car", bike and boat would not be recognized so you need to use what the objects had in common (Vehicle)
            // while a bike is not a car both are forms of transport (Vehicle)
            // meaning each object can be identified by more than one data type by using the parent class (this is an example of polymorphism) 
            Vehicle [] vehicles = { car, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();// for this we will need a go method within the vehicle class. to do this we will have to use a virtual override
            }


        }
    }
    class Vehicle
    {
        public virtual void Go()
        {
            // we dont explicitly need coed in this method because it will be overridden 
        }
    }
    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }
    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
}
