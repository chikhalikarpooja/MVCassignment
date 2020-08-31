using System;

namespace Examp8_PosndNegNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, count = 0, count1 = 0;
            int[] number = new int[5];
            Console.WriteLine("Enter positive or negative number");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number" + i);
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                if (number[i] > 0)
                {
                    count = count + 1;
                   
                }
                else if (number[i] < 0)
                {
                    count1 = count1 + 1;
                    
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
               
            }
            Console.WriteLine("Positive numbers are" + count);
            Console.WriteLine("Negative numbers are" + count1);
            Console.ReadKey();
        }
    }
}
