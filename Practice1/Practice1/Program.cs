using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class employee
    {
        public void employee_details( string name,string dob, string address)
        { 
           
            Console.WriteLine(name, dob, address);
        }

        public void employee_salary(double salary)
        {
            int pf = 1200;
            double total_salary= salary + pf;
            Console.WriteLine("Salary is:"+ total_salary);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            double salary1;
            string name, dob, address;
            Console.WriteLine("Enter the name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter DOB");
            dob = Console.ReadLine();
            Console.WriteLine("Enter the address");
            address = Console.ReadLine();
            Console.WriteLine("Enter your basic salary");
            salary1 = Convert.ToDouble(Console.ReadLine());
            employee emp = new employee();
            emp.employee_details(name,dob,address);
            emp.employee_salary(salary1);
            Console.ReadKey();
        }
    }
}
