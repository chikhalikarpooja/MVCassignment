using System;

namespace Examp3_divisibleornot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 % num2==0)
            {
                Console.WriteLine("number is divisible by second number");
            }
            else
            {
                Console.WriteLine("number is not divisible");
            }
            Console.ReadKey();
        }
    }
}
