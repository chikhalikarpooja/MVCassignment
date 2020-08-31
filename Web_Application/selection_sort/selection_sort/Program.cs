using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0 , k;
            int[] arr = new int[10];
            Console.WriteLine("Enter the element in the array");
            for( k = 0;k < 5;k++)
            {
                arr[k] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<5;i++)
            {
                for(int j=i+1;j<5;j++)
                {
                   if( arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
            
                }
                
            }
            for (k = 0; k < 5; k++)
            {
                Console.WriteLine(arr[k]);
            }
            Console.ReadKey();
        }

    }
}
