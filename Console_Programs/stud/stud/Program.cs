using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stud
{
     public class  school
    {
        public class  student
        {
            int rollno;
            string name;

          public student(int rno,string Name )
            {
                rollno = rno;
                name = Name; 
            }
            public student(student sd)
            {
                rollno = sd.rollno;
                name = sd.name;

            }
            ~student()
            {
                Console.WriteLine("destructor is called");
                Console.ReadKey();
            }

            public void show()
            {
                Console.WriteLine("roll no=" + rollno);
                Console.WriteLine("Name=" + name);
            } 
                 
        }
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            school.student s = new school.student(2,"arati");
            school.student s1 = new school.student(s);
           // Console.WriteLine("enter roll no");
           // s.rollno = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter name");
           // s.name = Console.ReadLine();
            s.show();
            s1.show();
            Console.ReadKey();

        }
    }
}
