using System;

namespace examp3_avgmaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0,i,size;
            float avg = 0;
           
            Console.WriteLine("How many students marks you wnt to enter");
             size = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[size];
            Console.WriteLine("Enter maths marks");
            for ( i = 0; i<size ; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                if (marks[i] <= 0)
                {
                    Console.WriteLine("Please enter positive number");
                    break;
                }
                                 
                total = total + marks[i];
            }
           
            avg = total / size ;
            Console.WriteLine("average is" + avg);
            Console.ReadKey();
        }
    }
}
