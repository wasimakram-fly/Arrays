using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a 2D array with 3 rows and 4 columns
            int[,] array2D = new int[3, 4];

            // Assign values to the array
            for (int row = 0; row < array2D.GetLength(0); row++)
            {
                for (int col = 0; col < array2D.GetLength(1); col++)
                {
                    array2D[row, col] = row + col;
                }
            }

            // Print the values in the array
            for (int row = 0; row < array2D.GetLength(0); row++)
            {
                for (int col = 0; col < array2D.GetLength(1); col++)
                {
                    Console.Write("{0} ", array2D[row, col]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
