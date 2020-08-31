using System;

namespace MultiLevel_Inheritance
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
    class PartTime:Students
    {
        public int hours;
        public void show(int Hour,string Name,string phono,string address,string salary)
        {
            Console.WriteLine("Partime Employee are:");
            hours = Hour;
            name = Name;
            PhoNo = phono;
            Address = address;
            Salary = salary;

            Console.WriteLine("Name is" + name);
            Console.WriteLine("Name is" + hours);
            Console.WriteLine("Name is" + PhoNo);
            Console.WriteLine("Name is" + Address);
            Console.WriteLine("Name is" + Salary);
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
            PartTime pt = new PartTime();
            Console.WriteLine("Enter Hours");
            pt.hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            pt.name = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            pt.PhoNo = Console.ReadLine();
            Console.WriteLine("Enter Address");
            pt.Address = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            pt.Salary = Console.ReadLine();
            pt.show(pt.hours,pt.name,pt.PhoNo,pt.Address,pt.Salary);
            Console.ReadKey();
        }
    }
}
