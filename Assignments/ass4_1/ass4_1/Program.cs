using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass4_1
{
    class addition
    {
        double sum= 0;
        public void calculate(double n)
        {
            for(double i=1;i<=n;i++)
            {
                sum = sum + 1 / i;
                
            }
        }
        public void showdata()
        {
            Console.WriteLine("sum=" + sum);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            addition add = new addition();
            Console.WriteLine("enter the number");
            num = Convert.ToDouble(Console.ReadLine());
            add.calculate(num);
            add.showdata();
            Console.ReadKey();
            


        }
    }
}
