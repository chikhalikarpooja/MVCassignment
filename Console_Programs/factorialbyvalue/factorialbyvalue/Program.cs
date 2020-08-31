using System;

namespace factorialbyvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,res;
            Console.WriteLine("enter no");
            num = Convert.ToInt32(Console.ReadLine());
            res = fact(num);
            Console.WriteLine("factorial=" + res);
        }
        static int fact(int n1)
        {
           int fact=1,i = 1;
            while(i<=n1)
            {
                fact = fact * i;
                i++;
            }
            return fact;
        }
    }
}
