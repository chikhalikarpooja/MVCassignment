using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_khansir_5
{
    class rectangle
    {
        public  int length { get; set; }
        public int breadth { get; set; }
        public rectangle(int len,int brth)
        {
            length = len;
            breadth = brth;
        }
        public double area()
        {

            return length * breadth;
                }
}
    class Program
    {
        static void Main(string[] args)
        {
            rectangle rect = new rectangle(4, 5);
           double result = rect.area();
            Console.WriteLine("area of rectangle 1=" + result);
            rectangle rect1 = new rectangle(5, 6);
            double result1 = rect1.area();
            Console.WriteLine("area of rectangle 2=" + result1);
            Console.ReadKey();
        }
    }
}
