using System;

namespace Examp3_numbersinline
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1;
            Console.WriteLine("Enter the lines");
            int lines = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    Console.Write(x++);
                    
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }
    }
}
