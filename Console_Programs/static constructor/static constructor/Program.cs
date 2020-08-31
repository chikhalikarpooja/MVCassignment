using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor
{
   public class adult
    {
       public static int minimumage;
        static adult()
        {
            minimumage = 18;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            adult a = new adult();
            Console.WriteLine("minimum age=" + adult.minimumage);
            Console.ReadKey();
        }
    }
}
