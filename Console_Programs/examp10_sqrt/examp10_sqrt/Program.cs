using System;

namespace examp10_sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the specified value ");
            size = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= size; i++)
            {
                if (i % 2 == 0)
                {
                    double square = i * i;
                    Console.WriteLine("Square of number{0} is{1}" ,i,square);
                }
            }
            Console.ReadKey();
        }
    }
}
