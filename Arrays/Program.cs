using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tmarks = 0;
            Console.Write("No. of student Entry: ");
            int noofstd=int.Parse(Console.ReadLine());
            int[] rno = new int[noofstd];
            string[] sname = new string[noofstd];
            int[] s1 = new int[noofstd];
            int[] s2 = new int[noofstd];
            int[] s3 = new int[noofstd];

            for(int i = 0; i < (noofstd); i++)
            {
                Console.Write("Enter Student Roll No.: ");
                rno[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter Student Name ( " + rno[i] + " ): ");
                sname[i] = Console.ReadLine();
                Console.Write("Enter " + sname[i] + " English Marks: ");
                s1[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter " + sname[i] + " Math Marks: ");
                s2[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter " + sname[i] + " Science Marks: ");
                s3[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
