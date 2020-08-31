using System;

namespace primerefrence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter no");
            num = int.Parse(Console.ReadLine());
            prime(ref num);
        }
        static void prime( ref int num1)
        {
            int i = 2, k = 1;
            while(i<= num1)
            {
                if(num1%i==0)
                {
                    k = k + 1;
                }
                i++;
            }
            if(k==2)
            {
                Console.WriteLine("prime no");
            }
            else
            {
                Console.WriteLine("not prime no");
            }
        }
    }
}
