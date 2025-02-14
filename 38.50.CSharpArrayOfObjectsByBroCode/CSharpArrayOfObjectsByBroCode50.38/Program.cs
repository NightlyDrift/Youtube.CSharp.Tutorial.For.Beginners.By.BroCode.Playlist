using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArrayOfObjectsByBroCode50._38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Car[] garage = new Car[3];
            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");
            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;*/
            //or can be written like so...
            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };


            // displayed by...
            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);
            // or
            foreach(Car car in garage)
            {
                Console.WriteLine(car.model);
            }
            

        }
    }
    class Car //class
    {
        public String model; // field 

        public Car(String model) //constructor to assign argument to model field
        {
            this.model = model;
        }
    }
}
