using System;

namespace khansir_assarray2
{
    class student
    {
       public int m1 { get; set; }
       public int m2 { get; set; }
       public int m3 { get; set; }
        int i;
        public void getdetails(int marks1,int marks2,int marks3,int i1)
        {
            m1 = marks1;
            m2 = marks2;
            m3 = marks3;
            i = i1+1;
            double avg = (m1 + m2 + m3) / 3;
            Console.WriteLine("Roll no" + i);
            Console.WriteLine("Average of 3 subjects marks is" + avg);
        }

     
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i ;
            student[] s = new student[3];
            for(i=0;i<3;i++)
            {
                s[i] = new student();
                Console.WriteLine("Enter subjects1 marks");
                 s[i].m1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter subject2 marks");
               s[i].m2  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter sibject3 marks");
               s[i].m3 = Convert.ToInt32(Console.ReadLine());
                s[i].getdetails(s[i].m1, s[i].m2, s[i].m3,i);
               
            }

            Console.ReadKey();
        }
    }
}
