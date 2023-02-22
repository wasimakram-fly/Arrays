using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s=new int[5];
            s[0] = 101;
            s[1] = 102;
            s[2] = 103;
            s[3] = 104;
            s[4] = 105; // array index ends with size-1.
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(s[i]); // all values stored in single variable 's'.
            }
            Console.ReadLine();
        }
    }
}
