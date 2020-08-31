using System;

namespace structure
{
    struct employee
    {
        public string firstname;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee companyemployee;
            Console.WriteLine("enter name and age");
            companyemployee.firstname = Console.ReadLine();
            companyemployee.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("firstname=" + companyemployee.firstname);
            Console.WriteLine("age=" + companyemployee.age);
            Console.ReadKey();
        }
    }
}
