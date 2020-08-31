using System;

namespace exam9_puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q, r, s;

            Console.WriteLine("Enter the 4 integier values");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());
            s = Convert.ToInt32(Console.ReadLine());
            if (p % 2 == 0)
            {
                Console.WriteLine("p is even");
            }
            else
            {


                Console.WriteLine("p is not even");
            }

            if (q > r && s > p)
            {

                if (r + s > p + q)
                {
                    Console.WriteLine("correct number");
                }
            }
            else
            {
                Console.WriteLine("incorrect number");
            }
                Console.ReadKey();
            }
        }

    }

