using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passarraybymethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter size");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("enter element");
            for(int i=0;i< n;i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            method(n, array);
            Console.WriteLine("display updated element");
            foreach(int i in array)
            {
                Console.WriteLine("i="+i);
            }
            Console.ReadKey();

        }
        static void method(int n,int[] array)
        {
            Console.WriteLine("display element");
            for(int i=0;i< n;i++)
            {

                Console.WriteLine(array[i]);
                array[i]++;
            }
        }
    
    }
}
