using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banklibrary;
namespace consolebank
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Account act = null;
            Console.WriteLine("enter the account no");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter account type(saving or current)");
            string acttype = Console.ReadLine();
            if (acttype=="saving")
            {
                act = new Saving();
               
            }
            else if (acttype=="current")
            {
                act = new Current();
               
            }
            act.AccountNo = actno;
            string res1 = act.Deposit(amount);
            Console.WriteLine(res1);
            Console.ReadKey();
            
        }
    }
}
