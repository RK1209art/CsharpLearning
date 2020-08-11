using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            // WAP to check two given integers, and return true if one of them is 30 or if their sum is 30.
             int a, b;
            
            Console.WriteLine("Enter the Number.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number.");
            b = Convert.ToInt32(Console.ReadLine());
            if(a==30 || b==30 ||(a+b)==30)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}
