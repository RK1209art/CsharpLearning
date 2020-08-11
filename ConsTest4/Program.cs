using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsTest4
{
    class Program
    {
        static void Main(string[] args)
        {
            //WAP to read the age of a candidate and determine whether it is eligible for casting his/ her own vote.
            int n;
            Console.WriteLine("Enter the Age");
            n=Convert.ToInt32(Console.ReadLine());

            if (n<18)
            {
                Console.WriteLine("Not Eligible for Vote");
            }
            else
            {
                Console.WriteLine("Eligible for Own Vote");
            }
            Console.ReadLine();
        }
    }
}
