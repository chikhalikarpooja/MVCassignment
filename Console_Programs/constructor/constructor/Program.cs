using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Bankaccount
    {
        public int actno;
        public Bankaccount()
        {
            actno = 45;
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bankaccount ba = new Bankaccount();
            Console.WriteLine("account no=" + ba.actno);
            Console.ReadKey();
        }
    }
}
