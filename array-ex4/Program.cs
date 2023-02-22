using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[] { 1, 2, 3, 4, 5 };
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.ReadLine();
        }
    }
}
