using System;

namespace Examp3_squareandcube
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the lines");
            int lines = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j < 2; j++)
                {
                    Console.Write("Square is"+" "+ num * num + ""+"Cube is" +" "+ num * num * num);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
