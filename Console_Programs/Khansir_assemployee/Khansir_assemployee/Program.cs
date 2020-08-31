using System;

namespace Khansir_assemployee
{
    class Adddistance
    {

        public void show(double res,double res1)
        {
            if(res1>12)
            {
                res++;
                res1 = res1 - 12;
                Console.WriteLine("YOur total distance in feet" + res + "and in inches" + res1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number  feet ");
            double feet1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter first number inch");
            double inch1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number  feet ");
            double feet2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter secong number inch");
            double inch2 = Convert.ToDouble(Console.ReadLine());

            double res = feet1 + feet2;
            double res1 = inch1 + inch2;
            Adddistance a = new Adddistance();
            a.show(res, res1);
            Console.ReadKey();
        }
    }
}
