using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconstructor
{
   public class simple
    {
        static long baseline;
        static simple()
            {
            baseline = DateTime.Now.Ticks;
            Console.WriteLine("baseline=" + baseline);

        }
        public simple()
        {
            Console.WriteLine("constructor is called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            simple s = new simple();
           
            Console.ReadKey();
        }
    }
}
