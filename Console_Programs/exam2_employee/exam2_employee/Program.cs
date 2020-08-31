using System;

namespace exam2_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            double empid;
            float hour , per_hr_sal,month_sal;
            Console.WriteLine("Enter the employee id");
            empid = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the hour");
            hour = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("enter your per hour salary");
            per_hr_sal = Convert.ToSingle(Console.ReadLine());

            month_sal = hour * per_hr_sal;

            Console.WriteLine("Employee id is" + empid);
            Console.WriteLine("per month salary is" + month_sal);
            Console.ReadKey();
        }
    }
}
