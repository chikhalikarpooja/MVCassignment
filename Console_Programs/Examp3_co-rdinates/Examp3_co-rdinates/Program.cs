using System;

namespace Examp3_co_rdinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y >0)
            {
                Console.WriteLine("{0} {1} Belongs to ++ Quadrant", x,y);
            }
            else if (x < 0 && y>0)
            {
                Console.WriteLine("{0} {1} Belongs to -+ Quadrant", x, y);
            }
            else if(x <0 && y<0)
            {
                Console.WriteLine("{0} {1} Belongs to -- Quadrant", x, y);
            }
            else if(x > 0 && y <0)
            {
                Console.WriteLine("{0} {1} Belongs to +- Quadrant", x, y);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.ReadKey();
        }
    }
}
