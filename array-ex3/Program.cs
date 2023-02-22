using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] s = new int[5];
            s[0] = 10;
            s[1] = 20;
            s[2] = 30;
            s[3] = 40;
            s[4] = 50;
            for(int i = 0; i < 5; i++)
            {
                sum = sum + s[i];
            }
            Console.WriteLine("sum of array values is: " + sum);
            Console.ReadLine();            
        }
    }
}
