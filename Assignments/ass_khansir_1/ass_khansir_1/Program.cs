using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_khansir_1
{
    class student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
         public void GetDetail(int rollNo,string name)
        {
            Name = name;
            RollNo = rollNo;
        }
        public void show()
        {
            Console.WriteLine( "Roll no="+RollNo);
            Console.WriteLine("Name=" + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student stud = new student();
            stud.GetDetail(2, "John");
            stud.show();
            Console.ReadKey();
        }
    }
}
