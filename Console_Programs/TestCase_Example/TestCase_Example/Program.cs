using System;

namespace TestCase_Example
{
    public class mathExample
    {
        public double add(double num1,double num2)
        {
            return num1 + num2;
        }
        public double sub(double num1,double num2)
        {
            return num1 - num2;
        }
        public double multiply(double num1,double num2)
        {
            return num1 * num2;
        }
        public double divide(double num1 , double num2)
        {
            return num1 / num2;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
          
            mathExample m = new mathExample();
            Console.WriteLine("Enter the two numbers");
            double num1 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToInt32(Console.ReadLine());
            double res = m.add(num1,num2);
            Console.WriteLine("result is" + res);
            Console.ReadKey();
        }
    }
}
