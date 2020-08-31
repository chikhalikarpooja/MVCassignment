
using System;

namespace polymorphisam
{
   public class Account
    {
        public int Acc_No { get; set; }
        public double Balance{get;set;}
       
        public Account()
        {
            Balance = 1000;
        }
        
        public virtual string deposit(int amount)
        {
            return "Empty";   
        }
        public void show(int AccountNumber)
        {
            
            Console.WriteLine("Balance of account number:" + AccountNumber + "is" + Balance);
        }
    }
   public class Saving:Account
    {
        public int interest { get; set; }

        public override string deposit (int amount)
        {
            interest = 200;
            Balance = Balance + amount+ interest;
            return "Total Amount After deposit amount:" + Balance;
        }
       
    }
   public class Current : Account
    {
        public override deposit(int amount)
        {
            Balance = Balance + amount;
            return "Total Amount After deposit amount:" + Balance;
        }
      
    }
    class Program
    {
        public delegate string accountdelegate(int amount);
        private event accountdelegate accountevent;
        static void Main(string[] args)
        {
            Program p = new Program();
            int acc_no, amount;
            Console.WriteLine("Enter Account Number");
            acc_no= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose one account saving or current");
            string atype = Console.ReadLine();
            Account ac = new Account();
            accountdelegate ad = null;
            if (atype=="saving")
            {

                p.accountevent += new accountdelegate(ac.deposit);
            }
            else if(atype=="current")
            {
                p.accountevent += new accountdelegate(ac.deposit);
                
            }
            string result = p.accountevent(amount);
            ac.show(acc_no);            
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
