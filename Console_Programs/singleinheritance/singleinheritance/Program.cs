using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleinheritance
{
    class person
    {
        public string Name { get; set; }
        public string Address { get; set; }

    }
    class Employee : person
    {
        public int EmployeeNumber { get; set; }
        public string Designation { get; set; }


        public void setData(string name, string address, int employeenumber, string designation)
        {
            Name = name;
            Address = address;
            EmployeeNumber = employeenumber;
            Designation = designation;
        }
        public  void showData()
        {
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Address=" + Address);
            Console.WriteLine("Employee id" + EmployeeNumber);
            Console.WriteLine("Designation" + Designation);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string EmpName, EmpAddress, EmpDesignation;
            int EmpId;
            Employee emp1 = new Employee();
            Console.WriteLine("enter the name");
            EmpName = Console.ReadLine();
            Console.WriteLine("enter the address");
            EmpAddress = Console.ReadLine();
            Console.WriteLine("enter the id");
            EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the designation");
            EmpDesignation = Console.ReadLine();
            emp1.setData(EmpName, EmpAddress, EmpId, EmpDesignation);
            emp1.showData();
            Console.ReadKey();
     

        }
    }
}
