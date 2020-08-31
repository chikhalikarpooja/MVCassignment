using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, res = 1,num;

            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            
            while(i<=num)
            {
                res = res * i;
                i++;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
