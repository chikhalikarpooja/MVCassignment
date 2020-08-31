using System;

namespace Exam8_characterinline
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine("Enter the lines");
            int lines = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("how many character you want in a single line");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(x++);

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
