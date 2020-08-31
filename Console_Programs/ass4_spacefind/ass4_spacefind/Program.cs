using System;

namespace ass4_spacefind
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]== ' ')
                {
                    count = count + 1;
                }
               
            }
            Console.WriteLine("Counter is" + count);
            Console.ReadKey();
        }
        
    }
}
