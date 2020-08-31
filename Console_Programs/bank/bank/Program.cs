using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class BankAccount
    {
        private string name;
        private double balance = 1000;
        public void deposit(string n,double amnt)
        {
            name = n;
            balance = balance + amnt;
            Console.WriteLine("deposit=" + balance);
        }
        public void withdrawl(string n,double amnt)
        {
            name = n;
            balance = balance - amnt;
            Console.WriteLine("withdrawl="+balance);
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
            Console.WriteLine("enter name and amount");
            string name = Console.ReadLine();
            int amount = Convert.ToInt32(Console.ReadLine());
            ba.deposit(name, amount);
            ba.withdrawl(name, amount);
            Console.ReadLine();

        }
    }
}
