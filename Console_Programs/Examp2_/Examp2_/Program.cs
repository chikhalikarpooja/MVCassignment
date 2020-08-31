using System;

namespace Examp2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number below 80");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0 && num <= 10)
            {
                Console.WriteLine("The {0} is between 0 to 10 " , num);
            }
            if (num >= 11 && num <= 20)
            {
                Console.WriteLine("The {0} is between 11 to 20" , num);
            }
            if (num >= 21 && num <= 30)

            {
                Console.WriteLine("The {0} is between 21 to 30 " , num);
            }
            if(num >= 31 && num <=40)
            {
                Console.WriteLine("The {0} is between 31 to 40 " , num);
            }
            if(num >=41 && num <=50)
            {
                Console.WriteLine("The {0} is between 41 to 50 " , num);
            }
            if(num >=51 && num <=60)
            {
                Console.WriteLine("The {0} is between 51 to 60 " + num);
            }
            if(num>= 61 && num <= 70)
            {
                Console.WriteLine("The {0} is between 61 to 70 " , num);
            }
            if(num >=71 && num <=80)
            {
                Console.WriteLine("The {0} is between 71 to 80 " , num);
            }
            else
            {
                Console.WriteLine("Number is greater than 80 !!!! please enter valid number");
            }
            Console.ReadKey();
        }
    }
}
