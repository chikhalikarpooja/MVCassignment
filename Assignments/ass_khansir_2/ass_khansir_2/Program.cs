using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_khansir_2
{
    class student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
      
        public void getdetail(int rollNo, string name )
        {
           
            
                RollNo = rollNo;
                Name = name;
        
            
        }
        public void Showdata()
        {
          
            Console.WriteLine("Roll no=" + RollNo);
            Console.WriteLine("Name=" + Name);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int Rollno=0;
            string Name=" ";
            Console.WriteLine("enter the size");
            int n = Convert.ToInt32(Console.ReadLine());
            //int[] Rollno = new int[n];
            //string[] Name = new string[n];
            student[] stud = new student[n];
            for (i = 0; i < n; i++)
            {
                stud[i] = new student();
                Console.WriteLine("enter the roll no");
                Rollno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the name");
                Name = Console.ReadLine();
                stud[i].getdetail(Rollno, Name);
            }
            for (i = 0; i < n; i++)
            {

             //   stud[i].getdetail(Rollno, Name);
                stud[i].Showdata();
            }
                Console.ReadKey();
            

            
        }
    }
}
