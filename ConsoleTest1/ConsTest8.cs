using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest1
{
    public class ConsTest8
    {
        int c;
        // WAP in C to display the cube of the number upto given an integer.
        public int CubeNo()
        {
            int n,Cub;
            Console.WriteLine("Enter the Number.");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                Cub = (i * i * i);
                Console.WriteLine(Cub);
                c = Cub;
            }
            return c;
            
        }
    }
}
