using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Functions1
{
    class Employee
    {
        public double amount = 1000;
 public double Withdraw(int x)
        {
            double res = amount-x ;
            return res;
        }

        public double Deposit (int y)
        {
            double res1 = amount + y;
            return res1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            int val1;
            Console.WriteLine("Enter the amount");
            val1 = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee();
           
           
            double result = emp.Withdraw(val1);
            Console.WriteLine("Amount after withdraw :"+result);
            double result1 = emp.Deposit(val1);
            Console.WriteLine("Amount after deposit:"+result1);
            Console.ReadKey();
        }
    }
}
