using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backswitch
{


    class BankAccount
    {
        public string name;
        public double balance = 1000;
        public static double interest = 200;

        public void deposit(string n, double amnt)
        {
            name = n;
            balance = balance + amnt + interest;
            Console.WriteLine("deposit=" + balance);
        }
        public void withdrawl(string n, double amnt)
        {
            name = n;
            balance = balance - amnt;
            Console.WriteLine("withdrawl=" + balance);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            BankAccount[] ba = new BankAccount[5];
            for (int i = 0; i < 5; i++)
            {
                ba[i] = new BankAccount();
                Console.WriteLine("enter name and amount");
                string name = Console.ReadLine();
                int amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter deposit or withdrawl");
                BankAccount.interest = 500;
                string t = Console.ReadLine();
                switch (t)
                {
                    case "deposit":
                        ba[i].deposit(name, amount);
                        break;
                    case "withrawl":
                        ba[i].withdrawl(name, amount);
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
            Console.ReadKey();

        }
    }

}

