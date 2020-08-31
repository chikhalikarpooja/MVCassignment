using System;

namespace exam4_disttravel
{
    class Program
    {
        static void Main(string[] args)
        {
            int km;
            float fuel , bike_avg;
            Console.WriteLine("Enter the kilometer");
            km = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fuel");
            fuel = Convert.ToSingle(Console.ReadLine());
            bike_avg = km / fuel;
            Console.WriteLine("Average of Bike consumption" + bike_avg);
            Console.ReadKey();
        }
    }
}
