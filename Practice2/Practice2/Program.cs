using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Bank
    {
     public   double amount = 1000;
       
        public void withdraw(int cash)
        {
            double amount1 = amount - cash;
            Console.WriteLine("Amount Balance:" + amount1);
        }
        public void deposit(int cash)
        {
            double amount2 = amount + cash;
            Console.WriteLine("Total Amount:" + amount2);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int cash1;
            Console.WriteLine("Enter the amount");
            cash1 = Convert.ToInt32(Console.ReadLine());
            string ch;
            Console.WriteLine("Press W for Withdraw and Press D for Deposit");
            ch = Console.ReadLine();
            Bank bank = new Bank();
            switch(ch)
            {
                case "W":
                   
                    bank.withdraw(cash1);
                    break;
                case "D":
                    bank.deposit(cash1);
                    break;
                default:
                    Console.WriteLine("Please enter correct value");
                    break;
            }
            Console.ReadKey();

        }
    }
}
