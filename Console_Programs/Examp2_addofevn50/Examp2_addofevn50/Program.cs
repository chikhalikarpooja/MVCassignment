using System;

namespace Examp2_addofevn50
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
           
            for (i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                   Console.WriteLine("All even numbers"+i);
                }
            }
            Console.ReadKey();
        }
    }
}
