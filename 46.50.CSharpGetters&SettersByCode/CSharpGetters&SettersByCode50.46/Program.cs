using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGetters_SettersByCode50._46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //getters & setters - adds security to fields via encapsulation (if you have a private field you can set up a public property with getters&setters)
            //                    They're accessors found within properties

            // property(-ies) - combines the aspects of both fields and methods ( and shares the same name with the field)
            //                  so kinda like something between a feild and a method
            //                  and contians get and set accessors
            // get accessor - is used to return the property value (get { return speed; })
            // set accessor - is used to assign a new value (see set below)
            // value keyword - defines the value being assigned by the set (kind of like an arguement and a parameter)




            Car car = new Car(400);//400 to represent speed

            //car.speed = 1000000000;
            // but how do we prevent speed field from being given an unreasonable value such as this?
            // using getters&setters (since setting the field to private wont allow us to access the field)
            // now field speed is inaccessable due to it being private (protection level) so we need to access the property instead...
            car.Speed = 1000000000;

            //Console.WriteLine(car.speed);
            Console.WriteLine(car.Speed);

        }

    }
    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }
        public int Speed//property, also property will have first letter capitalized
        {
            //lets assign the get accessor first
            get { return speed; } //this will read whatever value that is inn our field READABLE
            set // and we will need a set accessor if we want this to be writtable WRITABLE 
            {
                speed = value;
                // "value" is kind of like an arguement and a parameter. this will take the above code car.speed = 1000000000; and set it to equal "value"
                //here we can also set up some rules so if someone tries to change the speed we can write an if statement...
                if (value>500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            } 
        }
    }
}
