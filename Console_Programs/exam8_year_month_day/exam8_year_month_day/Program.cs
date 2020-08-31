using System;

namespace exam8_year_month_day
{
    class Program
    {
        static void Main(string[] args)
        {
            int days, year, month, no_day;
            Console.WriteLine("Enter days");
            no_day = Convert.ToInt32(Console.ReadLine());

            year = no_day / 365;

            days = no_day % 365;

            month = no_day / 30;

            Console.WriteLine("Year:" + year);
            Console.WriteLine("Month:" + month);
            Console.WriteLine("Days:" + days);

            Console.ReadKey();

        }
    }
}
