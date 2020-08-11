using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest1
{
    class Program
    {
        static void Main(string[] args)
        { //WAP to find the largest Number b/w two.
            int num1, num2;
            Console.WriteLine("Enter the Number.");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number.");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1 + "is the Largest Number");
            }
            else
            {
                Console.WriteLine(num2 + "is the Largest Number");
            }
            //Console.ReadLine();

            ConsTest7 ct = new ConsTest7();
           Console.WriteLine(ct.NaturalNo());
            Console.ReadKey();
        }

    }
}
