using System;

namespace ass_roshansir4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            n <<= 2;
            int b = n;
            Console.WriteLine("number is" + b);
            Console.ReadKey();
        }
    }
}
