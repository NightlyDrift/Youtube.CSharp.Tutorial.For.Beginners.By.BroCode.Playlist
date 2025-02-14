using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjectsByBroCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (for OOP (object oriented programming)
            //          Objects can have fields & Methods (characteristics & actions)  

            Human John = new Human();
            Human Jane = new Human();

            John.name = "John";
            John.age = 25;

            Jane.name = "Jane";
            Jane.age = 25;

            John.Eat();
            John.Sleep();

            Jane.Eat();
            Jane.Sleep();

            Console.ReadKey();

        }
    }

    class Human
    {
        public String name;//fields
        public int age;

        public void Eat()//methods
        {
            Console.WriteLine(name + " ate");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " slept");
        }



    }


}
