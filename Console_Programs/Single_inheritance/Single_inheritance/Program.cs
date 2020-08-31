using System;

namespace Single_inheritance
{
    class Person
    {
        public string name { get; set; }
        public string PhoNo { get; set; }
    }
        class Students : Person
        {
            public string Address { get; set; }
            public string Salary { get; set; }
            public void getdata()
            {
            Console.WriteLine("Employee name is:" + name);
            Console.WriteLine("Employee Phone number is:" + PhoNo);
            Console.WriteLine("Employee Address is:" + Address);
            Console.WriteLine("Employee Salary is:" + Salary);
            }
        

    }



    class Program
    {
        static void Main(string[] args)
        {
            Students s1 = new Students();
            
            Console.WriteLine("Enter name");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            s1.PhoNo = Console.ReadLine();
            Console.WriteLine("Enter Address");
            s1.Address = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            s1.Salary = Console.ReadLine();
            s1.getdata();
            Console.ReadKey();
        }
    }
}
