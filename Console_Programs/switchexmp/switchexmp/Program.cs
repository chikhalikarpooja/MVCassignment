using System;

namespace switchexmp
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter a character");
            ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'a' :
                case 'A':
                    Console.WriteLine("vowel is" + ch);
                    break;
                case 'e':
                case 'E':
                    Console.WriteLine("vowel is" + ch);
                    break;
                case 'i':
                case 'I':
                    Console.WriteLine("vowel is" + ch);
                    break;
                case 'o':
                case 'O':
                    Console.WriteLine("vowel is" + ch);
                    break;
                case 'u':
                case 'U':
                    Console.WriteLine("vowel is" + ch);
                    break;
                default:
                    Console.WriteLine("consonant is:" + ch);
                    break;

            }
        }
    }
}
