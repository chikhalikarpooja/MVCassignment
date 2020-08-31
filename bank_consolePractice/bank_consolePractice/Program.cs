using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_consolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int size, pos, num, i;

            Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements in array list");
            for(i=0;i<size;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("List before entering any element");
            for(i=0;i<size;i++)
            {
                Console.WriteLine("The array list is" + arr[i]);
            }

            Console.WriteLine("Enter the position where you want to enter element");
            pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number which you want to insert in array list");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = size; i >= pos;i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[pos - 1] = num;
            for(i=0;i<=size;i++)
            {
                Console.WriteLine("Updated array list is" + arr[i]);
            }
            Console.ReadKey();
        }
       
    }
}
