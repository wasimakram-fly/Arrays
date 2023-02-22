using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r, c, i, j;
            Console.Write("Enter row size: ");
            r=int.Parse(Console.ReadLine());
            Console.Write("Enter column size: ");
            c =int.Parse(Console.ReadLine());

            int[,] arr = new int[r, c];

            // int[, ] arr = new int[3, 3]; 3*3=9 elements.
            Console.WriteLine("Enter array elements:");

            for (i = 0; i < r; i++)
          //for (i = 0; i < 3; i++) \\after entering row size this loop will look like this
            {  // arr[0,0] [0,1]
                for (j = 0; j < c; j++)
              //for (i = 0; i < 3; i++) \\after entering column size this loop will look like this
                {
                    arr[i,j]=int.Parse(Console.ReadLine());
                }
            }
            // int[, ] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; here array value constructed
            Console.WriteLine("Entered array elements.");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + "         ");    // for printing rows.
                }
                Console.WriteLine(); // new line at each row.
            }
            Console.ReadLine();
        }
    }
}
