using System;

namespace Examp3_divisibleby7
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

            for (int i=num1; i<=num2;i++)
            {
                if(i % 7 == 2 ||  i % 7 == 3)
                {
                    sum = sum + i;
                    Console.WriteLine("Numbers which is divisible by 7 and reminder is 2 or 3"+" "+ i);
                }
            }
            Console.WriteLine("sum of numbers" +" "+ sum);
            Console.ReadKey();
        }
    }
}
