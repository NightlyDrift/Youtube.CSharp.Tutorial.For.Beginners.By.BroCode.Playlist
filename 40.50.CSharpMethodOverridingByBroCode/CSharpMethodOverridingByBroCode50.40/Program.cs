using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethodOverridingByBroCode50._40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method Overriding - provides a new version of a method inherited from a parent class...
            //                    To override a method it needs the same method signature (name and parameters) as the method being overriden
            // #3 EX              to create an overriding method the method that is inherited must be virtual, abstract or already overriden
            // #4 EX              you can do this with an abstract method too, but the class needs to be abstract as well, but also no code within the method
            //                    ... ,however the inherited method must be: abstract, virtual, or already overriden
            //                    Commonly Used with ToString() method and polymorphism 

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

        }
    }
    //#4
    /*abstract class Animal
    {
        public abstract void Speak()
    }*/
    class Animal
    {
        public virtual void Speak()//#3
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }
    }
    
}
