using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arr[0, 0]    arr[0, 1]   arr[0, 2]       //rows
            // arr[1, 0]    arr[1, 1]   arr[1, 2]
            // arr[2, 0]    arr[2, 1]   arr[2, 2]
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + "     ");
                }
                Console.WriteLine();    // new line at each row.
            }
            Console.ReadLine();
        }
    }
}
