using System;

namespace Examp3_password
{
    class Program
    {
        static void Main(string[] args)
        {
            double pwd;
            Console.WriteLine("Enter password");
            pwd = Convert.ToDouble(Console.ReadLine());
            switch(pwd)
            {
                case 1234:
                    Console.WriteLine("Correct password");
                    break;
                default:
                    Console.WriteLine("incorrect password");
                    break;
            }
            Console.ReadKey();
        }
    }
}
