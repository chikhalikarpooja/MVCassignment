using System;

namespace Examp2_Sumfoddnum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] odd = new int[5];
            int i,add=0;
            Console.WriteLine("Enter any 5 number");
            for( i =0; i<5;i++)
            {
                Console.WriteLine("Enter number"+ i);
                odd[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                if (odd[i] % 2 == 1)
                {
                    add = add + odd[i];
                }
            }
            Console.WriteLine("Addition of odd numbersn is :" + add);
            Console.ReadKey();
        }
    }
}
