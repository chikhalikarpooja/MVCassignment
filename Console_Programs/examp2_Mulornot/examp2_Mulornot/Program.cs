using System;

namespace examp2_Mulornot
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,temp=0;
            Console.WriteLine("Enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num2>num1)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            if(num1 % num2==0)
            {
                Console.WriteLine("Multiplied..!");
            }
            else
            {
                Console.WriteLine("Not Multiplied..!");
            }
            Console.ReadKey();
        }
    }
}
