using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, num1, res=1;
            Console.WriteLine("Enter any number");
            num1 = Convert.ToInt32(Console.ReadLine());

            while(i<num1)
            {
                if(num1 % i == 0)
                {
                    res = res + 1;
                }
                i++;

            }

            if(res==2)
            {
                Console.WriteLine("The number is prime");

            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
            Console.ReadKey();
        }
    }
}
