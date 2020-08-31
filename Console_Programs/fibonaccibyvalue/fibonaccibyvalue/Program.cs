using System;

namespace fibonaccibyvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter no");
            num = int.Parse(Console.ReadLine());
            fibonacci(num);
        }
        static void fibonacci(int num1)
        {
            int a = 0, b = 1;
            int c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            while (c <= num1)
            {
                c = a + b;
                if (c <= num1)
                {
                    Console.WriteLine(c);
                }
                a = b;
                b = c;


            }
        }

    }
}
