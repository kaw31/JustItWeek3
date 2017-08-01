using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6._5_DataStructuresRowNCol
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] grid = new int[5,5];
            Random rand = new Random();

            int[] rowTotals = new int[5];
            int[] columnTotals = new int[5];
            int overallTotal = 0;


            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i,j] = rand.Next(1, 11);
                    Console.Write(grid[i, j] + "\t");

                    rowTotals[i] += grid[i, j];
                    columnTotals[j] += grid[i, j];
                    overallTotal += grid[i, j];
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rowTotals.Length; i++)
            {
                Console.WriteLine("The total of row " + (i + 1) + " is " + rowTotals[i]);
            }
            for (int i = 0; i < columnTotals.Length; i++)
            {
                Console.WriteLine("The total of column " + (i + 1) + " is " + rowTotals[i]);
            }

            Console.WriteLine("The overall total is " + overallTotal);



        }
    }
}
