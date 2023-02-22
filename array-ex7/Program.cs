using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalcost = 0;
            Console.Write("Enter how many item want to purchase: ");
            int noofitem = int.Parse(Console.ReadLine());
            int[] ino = new int[noofitem];
            string[] iname = new string[noofitem];
            int[] qty = new int[noofitem];
            int[] cost = new int[noofitem];
            int[] total = new int[noofitem];

            for(int i = 0; i <= (noofitem - 1); i++)
            {
                Console.Write("Enter S.No. item no details: ");
                ino[i]= int.Parse(Console.ReadLine());
                Console.Write("Enter " + (i + 1) + " Item Name: ");
                iname[i]= Console.ReadLine();
                Console.Write("Enter quantity of " + iname[i] + ": ");
                qty[i]=int.Parse(Console.ReadLine());
                Console.Write("Enter cost of " + iname[i] + ": ");
                cost[i]=int.Parse(Console.ReadLine());
                total[i] = qty[i] * cost[i];
                finalcost = finalcost + total[i];
                Console.WriteLine();
            }
            // display the values.
           // Console.WriteLine("S.NO." + "\t" + "Item Name" + "\t" + "Quantity" + "\t" + "Price" + "\t" + "Total");

            Console.WriteLine("S.NO." + "\t" + "iname" + "\t" + "Qty" + "\t" + "Price" + "\t" + "Total");
            Console.WriteLine("------" + "\t" + "------" + "\t" + "----" + "\t" + "------" + "\t" + "------");
            Console.WriteLine();

            for(int j = 0; j <= (noofitem - 1); j++)
            {
                // Console.WriteLine(ino[j] + "\t" + iname[j] + "\t" + qty[j] + "\t" + cost[j] + "\t" + total[j]);

                Console.WriteLine(ino[j] + "\t" + iname[j] + "\t" + qty[j] + "\t" + cost[j] + "\t" + total[j]);
                Console.WriteLine();
            }
            Console.WriteLine("Total bill is: Rs." + finalcost);
            Console.ReadLine();
        }
    }
}
