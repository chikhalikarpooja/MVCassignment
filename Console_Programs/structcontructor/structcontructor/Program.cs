using System;

namespace structcontructor
{
    public struct employee
    {
        string name;
        int age;

        public employee(string a, int b)
        {
            name = a;
            age = b;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name and age");
            string n = Console.ReadLine();
            int d = Convert.ToInt32(Console.ReadLine());
            employee cmpyemp = new employee(n, d);
            Console.WriteLine("name=" + n);
            Console.WriteLine("age=" + d);
            Console.ReadKey();
        }
    }
}
