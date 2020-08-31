using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thi8skeyword
{
    class bankaccount
    {
        private string name;
        public void setname(string name)
        {
            this.name = name;
        }
        public void show()
        {
            Console.WriteLine("name=" + name);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            bankaccount ba = new bankaccount();
            ba.setname("arati");
            ba.show();
            Console.ReadKey();

        }
    }
}
