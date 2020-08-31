using System;

namespace paramsexample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,res;
            a = 34;
            b = 45;
            c = 56;
            res = add(a, b, c);
            Console.WriteLine("addition:" + res);
        }
        static int add(params int[] num)
        {
            int i;
           int  total = 0;
            for(i=0;i<num.Length;i++)
            {
                total = total + num[i];

            }
            return total;

        }
    }
}
