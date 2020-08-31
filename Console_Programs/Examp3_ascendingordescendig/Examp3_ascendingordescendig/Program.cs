using System;

namespace Examp3_ascendingordescendig
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("You Enter pair in decending order");
            }
            else
            {
                Console.WriteLine("You Enter pair in ascending order");
            }
            Console.ReadKey();
        }
    }
}
