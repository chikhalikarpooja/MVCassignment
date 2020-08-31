using System;

namespace Examp9_averageofposno
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,sum=0,count=0;
            float avg;
            int[] number = new int[5];
            Console.WriteLine("Enter positive or negative number");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number" + i);
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                if (number[i] > 0)
                {
                    sum = sum+number[i];
                    count++;
                }
                
            }
            avg = sum / count;
            Console.WriteLine("Average is:" + avg);
            Console.ReadKey(); 
        }
    }
}
