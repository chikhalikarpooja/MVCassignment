using System;

namespace khansirass_7
{
    public class Rectangle
    {
        int length { get; set; }
        int breath { get; set; }
        public void setdemo(int len, int bre)
        {
            length = len;
            breath = bre;
        }
        public double area()
        {
            return length * breath;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breath of rectangle");
            int len = Convert.ToInt32(Console.ReadLine());
            int bre = Convert.ToInt32(Console.ReadLine());
            Rectangle r = new Rectangle();
            r.setdemo(len, bre);
            double res = r.area();
            Console.WriteLine("Area of first rectangle:" + res);
           
            Console.ReadKey();
        }
    }

}
