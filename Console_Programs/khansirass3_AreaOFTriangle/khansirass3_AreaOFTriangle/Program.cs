using System;

namespace khansirass3_AreaOFTriangle
{
    class Triangle
    {
        public double per;
        public Triangle(int len,int hei,int breth)
        {
           
            per = len + hei + breth;
            Console.WriteLine("Perimeter is" + per);
        }
        public void area_of_triangle(int len1, int hei1, int breath1)
        {
            double area;
            area = (per - len1) * (per - hei1) * (per - breath1);
            double res = per * area;
            double res1 = Math.Sqrt(res);
            Console.WriteLine("Area of triangle is" + res1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Triangle t = new Triangle(3, 4, 5);
            
                t.area_of_triangle(3,4,5);
                    
            
            Console.ReadKey();
        }
    }
}
