using System;

namespace exam3_maxno
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the three number");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("{0} This no is greatest amongst three" , num1);
            }
            else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("{0} This no greatest amongst three" , num2);
            }
            else
            {
                Console.WriteLine("{0} This number is greatest amongst three" , num3);
               }
            Console.ReadKey();
        }
    }
}
