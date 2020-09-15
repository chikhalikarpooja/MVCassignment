using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertitanceAssignment_practice
{
    class Member
    {
      public  string name, age, phonenumber, address, salary;
       
       
        public void input()
        {
            Console.WriteLine("Enter the name of employee:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age of employee:");
            age = Console.ReadLine();
            Console.WriteLine("Enter the phonenumber of employee");
            phonenumber = Console.ReadLine();
            Console.WriteLine("Enter the address:");
            address = Console.ReadLine();
            Console.WriteLine("Enter the salary of employee");
            salary = Console.ReadLine();
        }
        
     
        public void displayemployee()
        {
            Console.WriteLine("Employee name is:" + name);
            Console.WriteLine("Employee age is:" + age);
            Console.WriteLine("Employee phonenumber is:" + phonenumber);
            Console.WriteLine("Employee address is:" + address);
           
        }
        public void printsalary()
        {
            Console.WriteLine("Total salary is:" + salary);
        }
    }
    class Employee : Member
    {
        string specialization ;
      public  void display()
        {
            Console.WriteLine("Enter the specilization of employee");
            specialization = Console.ReadLine();
            Console.WriteLine("Employee Spcilization is:" + specialization);
        }

    }
    class Manager : Member
    {
        string department;
       public void display1()
        {
            Console.WriteLine("Enter the department of employee");
            department = Console.ReadLine();
            Console.WriteLine("Employee department is:" +department);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Member m = new Member();
            m.input();
            m.displayemployee();
            m.printsalary();
            Employee emp = new Employee();
            emp.display();
            Manager m1 = new Manager();
            m1.display1();
            Console.ReadKey();
        }
    }
}
