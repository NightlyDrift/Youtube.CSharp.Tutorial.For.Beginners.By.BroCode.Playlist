using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfacesByBroCode50._43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface - much like a parent/ base(!) class an interface defines a sort of "contract" that all classes inheriting from it need to follow
            //             An interface can contain properties, methods, and events
            //             but any of these, when declared within an interface, need to be implemented within an inheriting class
            //
            //             An interface declares "what a class should have"
            //             An inheriting class defines "how it should do it"

            // Benefits - You can inherit multiple interfaces (unlike standard inheritance), gives the option of a more "plug n play" coding style,
            //            and adds a bit of extra security by using the "contract" to create firm rules for the inheriting classes
            //            security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            hawk.Hunt();
            rabbit.Flee();
            fish.Hunt();
            fish.Flee();

        }
        interface IPrey//interface naming convention is preceding the interface name with a capital I
        {
            void Flee();// declares method, but implementation is the job of the inheriting class
        }
        interface IPredator
        {
            void Hunt();
        }
        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit ran away!");//implememntation
            }
        }
        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food!");
            }
        }
        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away!");
            }
            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        }
    }
}
