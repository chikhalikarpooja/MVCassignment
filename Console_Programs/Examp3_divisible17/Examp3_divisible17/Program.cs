using System;

namespace Examp3_divisible17
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            for(int i= num1;i<=num2;i++)
            {
                if(i % 17 !=0)
                {
                    sum = sum + i;
                    Console.WriteLine("numbers are :" + i);
                }
            }
            Console.WriteLine("Sum of numbers" + sum);
            Console.ReadKey();
        }
    }
}
