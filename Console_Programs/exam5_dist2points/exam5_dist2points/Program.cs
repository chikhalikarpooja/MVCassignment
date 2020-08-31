using System;

namespace exam5_dist2points
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
                float sqrt;
            Console.WriteLine("Enter the first value of cordinate X ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value of cordinate X ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first value of cordinate Y ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value of cordinate Y ");
            y2 = Convert.ToInt32(Console.ReadLine());

            sqrt = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);

            double dis=Math.Sqrt(sqrt);
            Console.WriteLine("Distance of two points is:" + dis);
            Console.ReadKey();
        }
    }
}
