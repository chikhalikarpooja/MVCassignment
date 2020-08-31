using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_khansir_3
{
    class triangle
    {

       public int a,b,c;
        
        public double per;
       public double res2=0;
        public triangle(int aa,int bb,int cc)
        {
            a = aa;
            b = bb;
            c = cc;
        }
        public void perimeter()
        {
             per = a + b + c;
        }
        public void showperemiter()
        {
            Console.WriteLine("perimeter of triangle=" + per);
        }
        public void area()
        {
            double res = (per - a) * (per - b) * (per - c);
            double res1 = per * res;
            double res2 = Math.Sqrt(res1);

        }
        public void showarea()
        {
            Console.WriteLine("area of triangle=" + res2);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            triangle tri = new triangle(3, 4, 5);
            tri.perimeter();
            tri.showperemiter();
            tri.area();
            tri.showarea();
            Console.ReadKey();
        }
    }
}
