using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingarray
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("enter size");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("enter element");
            for(int i=0;i< n;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr = sorting(n, array);
            foreach(int i in array)
            {
                Console.WriteLine("i=" + i);
            }
            int sum = 0;
            for(int i=0;i<2;i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("sum=" + sum);
            Console.ReadKey();
        }
        static int[] sorting(int n, int[] array)
        {
            Array.Sort(array);
            return array;
        }

    }
}
