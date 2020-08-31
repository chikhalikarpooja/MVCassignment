using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringmessage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            showstring p = new showstring();
            p.message();
            Console.ReadKey();


        }

    }
}
    public  class showstring
    {

        public  string message()
        {
     
            Console.WriteLine("Welcome Friends");
            Console.WriteLine("Have a nice Day");
        return "";
        }

    }
    

