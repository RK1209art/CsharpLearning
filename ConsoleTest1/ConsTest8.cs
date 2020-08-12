using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest1
{
    public class ConsTest8
    {

        // WAP in C to display the cube of the number upto given an integer.
        int c;
        public int CubeNo()
        {
            int n,cub;
            Console.WriteLine("Enter the number.");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n;i++)
            {
                cub = (i * i * i);
                Console.WriteLine(cub);
                c = cub;
            }
            return c;
        }
    }
}
