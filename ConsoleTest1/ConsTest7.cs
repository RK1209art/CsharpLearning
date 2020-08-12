using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest1
{
    public class ConsTest7
    {
        //WAP in C to display n terms of natural number and their sum.
        public int NaturalNo()
        {
            int n,sum = 0;
            Console.WriteLine("Enter Integer Number.");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            return sum;

        }
    }
}
