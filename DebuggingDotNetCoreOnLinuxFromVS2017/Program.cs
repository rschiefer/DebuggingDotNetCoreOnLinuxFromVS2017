using System;

namespace DebuggingDotNetCoreOnLinuxFromVS2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var message = $"Hello {name} from {System.Environment.MachineName}!";
            Console.WriteLine(message);
            
            Console.WriteLine("Where are you from?");
            var from = Console.ReadLine();
            var fromMessage = $"{from} sounds like a cool place.";
            Console.WriteLine(fromMessage);

            Console.ReadLine();
        }
    }
}