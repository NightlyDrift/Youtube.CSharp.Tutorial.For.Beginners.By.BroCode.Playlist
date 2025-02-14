using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpMultithreadingByBroCode50._50LFG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // thread - a thread is an execution path of a program
            //          We can use multiple threads to perform different tasks of our program at the same time.
            //          When we begin out program we have one thread that is running and that is our (/Current thread running is) "main" thread
            //          using System.Threading; is the default imported namespace used to add this functionality
            //          (tho System.Threading.Tasks; is what i see up there so im just gonna test it to see if they are the same. maybe im just running on a more updated version of visual studio)

            Thread mainThread = Thread.CurrentThread;//this will assign the current thread that is running to our variable "mainThread"
            mainThread.Name = "Main Thread";// ".Name" names the thread with a string data type
            Console.WriteLine(mainThread.Name);// and display the thread name

            //lets create two timers working at the same time, one counting up and the other down... 1)
            //Now lets invoke both methods...
            //CountDown();
            //CountUp();
            Console.WriteLine(mainThread.Name + " is complete!");
            //But both of these are running on the same thread. meaning they wont both run simultaneously
            // So lets create some additional threads
            //Thread thread1 = new Thread(CountDown);
            //Thread thread2 = new Thread(CountUp);
            //thread1.Start();
            //thread2.Start();
            //Now if you have a method which has parmaeters there is one additional step... 2)
            //Then to invoke these methods you write
            Thread thread1 = new Thread(() => CountDown("Timer #1"));//lambda expression - "() => methodname(arguments), never really explained...
            Thread thread2 = new Thread(() => CountUp("Timer #2"));
            thread1.Start();
            thread2.Start();

        }
        // 1)
        public static void CountDown(String name)// 2) add "String name" to brackets
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
    }
}

