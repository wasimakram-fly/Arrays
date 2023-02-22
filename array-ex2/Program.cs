using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[5];
            s[0] = "Swaraj";
            s[1] = "Wasim";
            s[2] = "Sneha";
            s[3] = "Naveen";
            s[4] = "Divya"; // array index ends with size-1.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(s[i]); // all values stored in single variable 's'.
            }
            Console.ReadLine();
        }
    }
}
