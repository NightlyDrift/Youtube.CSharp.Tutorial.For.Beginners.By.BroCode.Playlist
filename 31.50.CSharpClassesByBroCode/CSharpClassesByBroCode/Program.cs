using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassesByBroCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // class = A bundle of related code.
            //         Can be used as a blueprint to create objects (for OOP (Object Oriented Programing))

            Messages.Hello("sometyhingh");
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }
}
