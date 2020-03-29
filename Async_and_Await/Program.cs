using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await
{
    class Program
    {

        static string processConnectToDatabase = "(Connecting to database)";
        static string processGetDataFromDatabase = "(Getting data from database)";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am a newbie but i hope one day I can become a Legend");

            Console.WriteLine("First we are inside the main method...");
            RunProcess(1, 1_000_000);   //Ho dichiarato il primo processo

            var dbTask = ConnectToDatabaseProcessAndGetData();
            Console.WriteLine("Back to the main method");

            if (dbTask.Status == TaskStatus.RanToCompletion)
                Console.WriteLine($"Process {processConnectToDatabase} is completed.");
            else
                Console.WriteLine($"Process {processConnectToDatabase} is NOT completed.");


            RunProcess(2, 1_000_000);   //ora il secondo processo
            RunProcess(3, 1_000_000);   //ora il terzo processo
            RunProcess(4, 1_000_000);   //ora il quarto processo

            Console.ReadLine();

        }

        public static async Task ConnectToDatabaseProcessAndGetData()
        {
            Console.WriteLine($"\nControl is with process {processConnectToDatabase}.");
            Console.WriteLine($"Process {processConnectToDatabase} has started.");
            Console.WriteLine($"Process {processConnectToDatabase} is running...");
            await Task.Run(() =>        //Await permette al task di essere eseguita e nel mentre fa andare le altre task che susseguono questa
            {
                Console.WriteLine("Start executing process in the await section.");
                Thread.Sleep(7000);
                RunProcess(10, 100000);
                Console.WriteLine("\nProcess in the await section is complete!");
            });
            Console.WriteLine($"\nProcess {processConnectToDatabase} is complete!");
            Console.WriteLine($"Control is with process {processGetDataFromDatabase} again");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Getting data..... " + i);
            }
            Console.WriteLine($"Process {processGetDataFromDatabase} is complete!");
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

