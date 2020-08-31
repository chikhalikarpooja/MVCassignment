using System;

namespace Object_dataClass
{
    class Bank
    {
        private string name;
        private double balance = 1000;

        public void deposit(string n, double amount)
        {
            name = n;
            balance = balance + amount;
            Console.WriteLine("deposited balance by{0} is {1}", name, balance);
        }
        public void withdraw(string n,double amount)
        {
            name = n;
            balance = balance - amount;
            Console.WriteLine("Withdraw balance by {0} is {1}", name, balance);
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double amount;
            Bank[] b = new Bank[3];
            for (int i = 0; i < 3; i++)
            {
                b[i] = new Bank();
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter amount");
                amount = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Deposit or Withdraw");
                string ch = Console.ReadLine();

                switch (ch)
                {
                    case "Deposit":
                        b[i].deposit(name, amount);
                        break;
                    case "Withdraw":
                        b[i].withdraw(name, amount);
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
