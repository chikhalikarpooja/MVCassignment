using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_khansir_6
{


    class Area
    {
        public int length { get; set; }
        public int breadth { get; set; }
        public void setDim(int len, int brth)
        {
            length = len;
            breadth = brth;
        }
        public double getArea()
        {

            return length * breadth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int length1, breadth1;
            Console.WriteLine("enter the length");
            length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the breadth");
            breadth1 = Convert.ToInt32(Console.ReadLine());
            Area ar = new Area();
             ar.setDim(length1, breadth1);
            Console.WriteLine("area="+ar.getArea());
            Console.ReadKey();
        }
    }
}