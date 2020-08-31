using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismeg
{
    class figure
    {
        public virtual void draw()
        {
            Console.WriteLine("figure class is called");
        }
    }
    class rectangle:figure
    {
        public override void draw()
        {
            Console.WriteLine("rectangle class is called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            figure fig = new rectangle();
            fig.draw();
            Console.ReadKey();

        }
    }
}
