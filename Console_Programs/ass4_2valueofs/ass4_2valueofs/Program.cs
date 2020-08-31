using System;

namespace ass4_2valueofs
{

    class ValueOfS
    {
        public double s = 1;
        double i = 1,n=1;
        public void Calculate(int num1)
        {
            for (double j = 1; j <= num1; j++)
            {
                while ( i <= num1)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine("value of i:" + i);
                        i++;
                    }
                        if (j % 2 == 0)
                        {
                            j++;
                            
                            Console.WriteLine("value of j:" + j);
                        }
                    
                    s = s + j/i;

                    j++; 
                    i++;

                }
            }
            Console.WriteLine("Sum:" + s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            ValueOfS s = new ValueOfS();
            int num = Convert.ToInt32(Console.ReadLine());
            s.Calculate(num);
            Console.ReadKey();
        }
    }
}
