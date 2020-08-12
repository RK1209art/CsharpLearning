using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest1
{
    public class ConsTest9
    {
        int s;
        //WAP in C to make such a pattern like right angle triangle with a number which will repeat a number in a row.
        public int RightAngle()
        {
            int n;
            Console.WriteLine("Enter the Number.");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                        Console.Write(i);
                        s = (i);
                }
                Console.WriteLine();
            }
            return s;
        }
    }
}
