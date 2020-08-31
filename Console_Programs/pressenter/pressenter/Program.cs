using System;

namespace pressenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press enter to exit frrom screen");
            while(Console.ReadKey().Key !=ConsoleKey.Enter)
            {
                Console.WriteLine("press enter key");
            }
        }
    }
}
