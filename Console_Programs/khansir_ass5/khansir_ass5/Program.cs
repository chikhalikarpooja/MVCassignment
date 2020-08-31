using System;

namespace khansir_ass5
{
    class Rectangle
    {
        int length { get; set; } 
          int breath { get; set; }
        public Rectangle(int len,int bre)
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
            Console.WriteLine("Enter length and breath of first rectangle");
            int len = Convert.ToInt32(Console.ReadLine());
            int bre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length and breath of first rectangle");
            int len1 = Convert.ToInt32(Console.ReadLine());
            int bre1 = Convert.ToInt32(Console.ReadLine());
            Rectangle r = new Rectangle(len, bre);
            double res=r.area();
            Console.WriteLine("Area of first rectangle:" + res);
            Rectangle r2 = new Rectangle(len1, bre1);
            double res1=r2.area();
            Console.WriteLine("Area of seconf rectangle :" + res1);
            Console.ReadKey();
        }
    }
}
