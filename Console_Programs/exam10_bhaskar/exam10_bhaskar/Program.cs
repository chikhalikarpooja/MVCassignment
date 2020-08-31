using System;

namespace exam10_bhaskar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2, num3;
            double root = 0;
            Console.WriteLine("Enter number1");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number3");
            num3 = Convert.ToInt32(Console.ReadLine());

            int res = (num2 * num2) - (4 * num * num3);
            root = Math.Sqrt(res);
            if (root > 0 && num != 0)
            {
                double x, y;
                x = (-num2 + root) / (2 * num);
                y = (-num2 - root) / (2 * num);
                Console.WriteLine("X is" + x);
                Console.WriteLine("Y is" + y);
            }
            else
            {
                Console.WriteLine("Equation is not valid");
            }
            Console.ReadKey();
        }
    }
}
