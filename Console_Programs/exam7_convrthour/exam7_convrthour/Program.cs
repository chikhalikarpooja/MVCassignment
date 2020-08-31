using System;

namespace exam7_convrthour
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec, hour, min, sec1;
            Console.WriteLine("Enter seconds");

            sec = Convert.ToInt32(Console.ReadLine());

            hour = sec / 3600;

            min = (sec - (3600 * hour)) / 60;

            sec1 = (sec - (3600 * hour) - (60 * min));

            Console.WriteLine("Hour:" + hour);
            Console.WriteLine("Minuite" + min);
            Console.WriteLine("seconds" + sec1);
            Console.ReadKey();
        }
    }
}
