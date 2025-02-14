using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOutputByBroCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HEY!");
            Console.Write("HELLO!");

            //This is a comment
            /*
             * this
             * is
             * a
             * multiline
             * comment
             */

            /*Escape Sequence       Represents                  Result
             * \a                   Bell (alert)                *plays default windows alert bell*
             * \b                   Backspace                   Deletes one letter or keystroke before the escape sequence
             * \f                   Form feed                   "from here...
             *                                                  to here"        !!!there may be something more to this one...
             * \n                   New Line                    "from here...
             *                                                  to here"
             * \r                   Carriage return             Deletes everything prior to this escape sequence
             * \t                   Horizontal tab              "From here to(tab)   here"
             * \v                   Vertical tab                "from here...
             *                                                  to here"
             * \'                   Single quotation mark       "'"
             * \"                   Double quotation mark       """
             * \\                   Backslash                   "/"
             * \?                   Literal Question mark       "?" !!!or is supposed to but visual studio failed to recognize this escape sequence
             */

            Console.WriteLine(" ");
            Console.WriteLine("\a BroCode");
            Console.WriteLine(" ");
            Console.WriteLine("Bro\bCode");
            Console.WriteLine(" ");
            Console.WriteLine("Bro\fCode");
            Console.WriteLine(" ");
            Console.WriteLine("Bro\nCode");
            Console.WriteLine(" ");
            Console.WriteLine("Bro\rCode");
            Console.WriteLine(" ");
            Console.WriteLine("Bro\tCode");
            Console.WriteLine(" ");
            Console.WriteLine("Bro\vCode");
            Console.WriteLine(" ");
            Console.WriteLine("\'BroCode\'");
            Console.WriteLine(" ");
            Console.WriteLine("\"BroCode\"");
            Console.WriteLine(" ");
            Console.WriteLine("Bro\\Code");
            Console.WriteLine(" ");
            Console.WriteLine("Bro Code");
            Console.WriteLine(" ");

            Console.ReadKey();
            /*Asking for a single key to be pressed and read by the command.
             * This is used so that the end of the program doesn't show the info dump. aka AESTHETIC.*/
        }
    }
}
