using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsTest6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C program to find whether a given year is a leap year or not.
            int year;
            Console.WriteLine("Enter the Year");
            year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0)
            {
                Console.WriteLine(year + "is Leap year.");
            }
            else
            {
                Console.WriteLine(year + "is Not leap Year.");
            }
            Console.ReadLine();
        }
    }
}
