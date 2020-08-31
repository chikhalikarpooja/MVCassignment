using System;

namespace ass3_add2no
{
    public               class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int num1, num2;
            Console.WriteLine("Enter the two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            int res = p.function1(num1,num2);
            Console.WriteLine("Addition is" + res);
        }
        public int function1(int num1, int num2)
        {
            int res;
            res = num1 + num2;
            return res;
        }


    }
}
