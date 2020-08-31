using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sp;
           
            for(i=1;i<=5;i++)
            {
                for(sp=4;sp>=i;sp--)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" \n");
            }
            Console.ReadKey();
        }

    }
}
