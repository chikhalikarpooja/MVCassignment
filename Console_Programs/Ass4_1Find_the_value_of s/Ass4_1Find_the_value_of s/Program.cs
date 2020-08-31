using System;

namespace Ass4_1Find_the_value_of_s
{

    class ValueOfS
    {
        public double s=0;
        double i = 1;
        public void Calculate(int num1)
        {
           while(i<=num1)
            {
                s = s + 1/i;

                i++;

            }
            Console.WriteLine("value of s:" + s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            ValueOfS s = new ValueOfS();
            int num = Convert.ToInt32(Console.ReadLine());
            s.Calculate(num);
            Console.ReadKey();
        }
    }
}
