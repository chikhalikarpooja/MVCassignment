using System;

namespace exam6_banknotes
{
    class Program
    {
        static void Main(string[] args)
        {
            double amt=0;
            double n100, n50, n20, n10, n5;
            Console.WriteLine("Enter the amount");
            amt = Convert.ToDouble(Console.ReadLine());
            n100 = amt / 100;
            
            n50 = amt / 50;
            
            n20 = amt / 20;
            
            n10 = amt / 10;
            
            n5 = amt / 5;
                      Console.WriteLine("no of 100 notes" + n100);
            Console.WriteLine("no of 50 notes" + n50);
            Console.WriteLine("no of 20 notes" + n20);
            Console.WriteLine("no of 10 notes" + n10);
            Console.WriteLine("no of 5 notes" + n5);
            //Console.WriteLine("no of notes" + res);
            Console.ReadKey();


        }
    }
}
