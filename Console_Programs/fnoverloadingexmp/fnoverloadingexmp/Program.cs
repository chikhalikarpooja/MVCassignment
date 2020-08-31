using System;

namespace fnoverloadingexmp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 10;
            float res;
            float d = 1.67f;
            res = add(a,d);
            Console.WriteLine(res);
        }
        static int add(int a ,int b)
        {
            return a + b;  
        }
        static int add(int a, int b,int c)
        {
            return a + b + c;

        }
        static float add(int a, float d)
        {
            return a + d;
        }
    }
}
