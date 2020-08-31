using System;

namespace AssRoshansir_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            n = n << 2;
            
            Console.WriteLine("number is" + n);
            Console.ReadKey();
        }
    }
}
