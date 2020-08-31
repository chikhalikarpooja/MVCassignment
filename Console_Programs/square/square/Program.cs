using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            int sqr;
            Console.WriteLine("enter a no");;
            int num = int.Parse(Console.ReadLine());
            sqr = num * num;
            Console.WriteLine("square is:" + sqr);

        }
    }
}
