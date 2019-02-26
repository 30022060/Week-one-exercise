using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOneConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            Console.WriteLine(" Enter your age.");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();


            Console.WriteLine(name + age);
            Console.ReadLine();
            

        }
    }
}
