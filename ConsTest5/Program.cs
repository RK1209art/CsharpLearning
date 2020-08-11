using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsTest5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C program to find the largest of three numbers.
            int a, b, c;
            Console.WriteLine("Enter the Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number");
            c = Convert.ToInt32(Console.ReadLine());
            if (a>b && a>c)
            {
                Console.WriteLine(a + "is largest Number");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine(b + "is largest Number");
            }
            else
            {
                Console.WriteLine(c + "is largest Number");
            }
            Console.ReadLine();
        }
    }
}
