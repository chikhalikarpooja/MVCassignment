using System;

namespace usingforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("enter size");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("enter element");
            foreach(int i in a)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());      
            }
            Console.WriteLine("display element");
            foreach(int h in a)
            {
                Console.WriteLine(h);
            }
        }
    }
}
