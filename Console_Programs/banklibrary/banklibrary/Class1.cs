using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banklibrary
{
    public abstract class Account
    {
        public int AccountNo { get; set; }
        public double balance { get; set; }

        public Account()
        {
            balance = 1000;
        }
        public abstract string Deposit(int amt);
        public abstract string withdrawl(int amt);
    }
     public class Saving:Account
    {
        public override string Deposit(int amt)
        {
            int interest = 500;
            balance = balance + amt+interest;
            return "  saving balance after deposit is:" + balance;

        }
        public override string withdrawl(int amt)
        {
            balance = balance -amt ;
            return "saving  balance after withwrawl is:" + balance;

        }

    }
   public  class Current:Account
    {
        public override string Deposit(int amt)
        {
           
            balance = balance + amt ;
            return "current balance after deposit is:" + balance;

        }
        public override string withdrawl(int amt)
        {
            balance = balance - amt;
            return " current balance after withwrawl is:" + balance;

        }


    }





}

