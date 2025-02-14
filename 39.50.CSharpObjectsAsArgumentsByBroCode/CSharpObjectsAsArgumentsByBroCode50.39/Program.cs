using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjectsAsArgumentsByBroCode50._39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //how to pass an argument as an object

            Car car1 = new Car("Mustang", "Red");

            //ChangeColor(car1, "Silver");
            Car car2 = Copy(car1);

            Console.WriteLine($"{car1.color} {car1.model}");
            Console.WriteLine($"{car2.color} {car2.model}");

        }
        // lets create a method to change the car color...
        public static void ChangeColor(Car car, String Color)
        {
            car.color = Color;
        }
        // Now lets create a mmethod to copy an obnject

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
    class Car //class
    {
        public String model;//fields
        public String color;

        public Car(String model, String color)//constructor
        {
            this.model = model;
            this.color = color;
        }
    }
}
