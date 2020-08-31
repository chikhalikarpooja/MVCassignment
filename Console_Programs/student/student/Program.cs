using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class students
    {
       static int rollno=1 ;
        static string name="arati" ;
     
        public void show()
        {
            Console.WriteLine("roll no=" + rollno);
            Console.WriteLine("name=" + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            students s = new students();
            
            s.show();
            Console.ReadKey();
        }
    }
}
