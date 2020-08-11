using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            // WAP to get the absolute difference between n and 51.If n is greater than 51 return triple the absolute difference.
            int n, m = 51,sub;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            sub = (n - m);
            if (n>51)
            {
                Console.WriteLine(sub * 3 + " is triple the absolute difference.");
            }
            else
            {
                Console.WriteLine(sub + "is only absolute difference.");
            }
            Console.ReadLine();
        }
    }
}
