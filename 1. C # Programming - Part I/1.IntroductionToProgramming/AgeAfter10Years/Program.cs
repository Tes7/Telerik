using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            age = age + 10;
            Console.WriteLine(age);
        }
    }
}
