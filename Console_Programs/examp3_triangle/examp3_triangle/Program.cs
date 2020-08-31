using System;

namespace examp3_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, per, tri;
            Console.WriteLine("Enter side 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side 2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side 3");
            c = Convert.ToInt32(Console.ReadLine());

            if(a<(b+c) && b<(a+c) && c<(a+b))
            {
                per = a + b + c;
                Console.WriteLine("Perimeter is :" + per);
            }
            else
            {
                Console.WriteLine("triangle is invalid");
            }
            Console.ReadKey();
        }
    }
}
