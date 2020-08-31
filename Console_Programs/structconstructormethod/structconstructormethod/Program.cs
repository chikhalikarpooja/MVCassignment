using System;

namespace structconstructormethod
{
    public struct employee
    {
        string name;
        int age;

        public employee(string a, int b)
        {
            name = a;
            age = b;

        }
    }
    class Program
    {
        public void display()
        {
            Console.WriteLine("name=" +cmpyemp                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           .name);            


        }
        static void Main(string[] args)
        {
        Console.WriteLine("enter name n age");
        string n = Console.ReadLine();
        int d = Convert.ToInt32(Console.ReadLine());
        employee cmpyemp = new employee(n, d);
            cmpyemp.display();

    }
    