using System;

namespace stringlencount
{
    class Program
    {
        static void Main(string[] args)
        {
            string name,rev=" ";
            name = Console.ReadLine();
            int i,j,len=0,count=0;
            for (i = 0; i < name.Length; i++)
            {
                count++;
            }
            len = count-1;
            
               
            while(len>=0)
            {
                rev = rev + name[len];
                len--;
            }
            Console.WriteLine(rev);
            
        }
    }
}
