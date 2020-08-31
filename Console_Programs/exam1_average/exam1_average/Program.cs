
using System;

namespace exam1_average
{
    class Program
    {
        static void Main(string[] args)
        {
            float w1, c1, w2, c2, avg;
            Console.WriteLine("Enter the weight1");
            w1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the item1");
            c1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the weight2");
            w2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the item2");
            c2 = Convert.ToSingle(Console.ReadLine());
            avg = ((w1 * c1) + (w2 * c2)/(c1+c2));
            Console.WriteLine("The average of value items"+avg);
            Console.ReadKey();

        }
    }
}
