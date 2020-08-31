using System;

namespace Ass_Khansir_complexnumber
{
    class complex
    {
        public void Addition(double com1 , double com2)

        {
            double add = com1 + com2;
            Console.WriteLine("Addition of two complex number:" + add);

        }
        public void Substraction(double com1 , double com2)
        {
            double sub = com1 - com2;
            Console.WriteLine("substraction of two number :" + sub);
        }
        public void Product(double com1, double com2)
        {
            double mul = com1 * com2;
            Console.WriteLine("Product of two complex number :" + mul);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter real Number");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Imaginary Number");
            int im = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of i");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second real Number");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second imaginary number");
            int im1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of i");
            double i1 = Convert.ToDouble(Console.ReadLine());

            double complex1 = r + (im * i);
            double complex2 = r1 + (im1 * i1);

            complex c = new complex();
            c.Addition(complex1, complex2);
            c.Substraction(complex1, complex2);
            c.Product(complex1, complex2);

            Console.ReadKey();
        }
    }
}
