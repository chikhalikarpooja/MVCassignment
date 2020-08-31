using System;

namespace Nivswitch
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            //int num = 12;
            //bool n;
                switch (num)
                {
                case 1 : if(num<0)
                        
                            Console.WriteLine("negative number");
                        
                        break;
                case 2: if(num>0)
                        
                            Console.WriteLine("positive number");
                        
                        break;
                    default:
                        Console.WriteLine("is equal to zero");
                        break;
                }
            
            Console.ReadKey();
        }
    }
}
