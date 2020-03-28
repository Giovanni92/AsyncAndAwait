using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_and_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am a newbie but i hope one day I can become a Legend");

            Console.WriteLine("First we are inside the main method...");
            RunProcess(1, 1_000_000);   //Ho dichiarato il primo 
            RunProcess(2, 1_000_000);   //e il secondo processo

            Console.ReadLine();

            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");

        }

        private static void RunProcess(int processNumber, int processLoopCondition)
        {
            Console.WriteLine("\nControl is with process " + processNumber);
            Console.WriteLine($"Process ({processNumber}) has started.");
            Console.WriteLine($"Process ({processNumber}) is running...");
            for (int i = 0; i < processLoopCondition; i++)
            {
            }
            Console.WriteLine($"Process ({processNumber}) is complete");
            Console.WriteLine("Control is back to main method");
        }
    }

}

