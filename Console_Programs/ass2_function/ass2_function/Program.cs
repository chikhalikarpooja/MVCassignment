using System;

namespace ass2_function
{
   public class Program
    {
      public static void Main(string[] args)
        {
            //            Console.WriteLine("Hello World!");
            string name;
            Console.WriteLine("Enter name john");
            name = Console.ReadLine();
            Program p = new Program();
            string name2 = p.function1(name);
            Console.ReadKey();
        }

        public string function1(string name2)
        {
            Console.WriteLine("Welcome Friend" + name2);
            Console.WriteLine("Have a nice day");

            return name2;
        }
    }
}
