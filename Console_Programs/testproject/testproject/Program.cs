using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testproject
{
    public class mathexample
    {
        public double add(double a, double b)
        {
            return a + b;
        }
        public double sub(double a,double b)
        {
            return a - b;
        }
        public double mul(double a, double b)
        {
            return a*b;
        }
        public double div(double a, double b)
        {
            return a/b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            mathexample ma = new mathexample();
            Console.WriteLine("enter value of a & b");
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double res = ma.add(a,b);
            Console.WriteLine("result=" +res);
            Console.ReadKey();



        }
    }
}
