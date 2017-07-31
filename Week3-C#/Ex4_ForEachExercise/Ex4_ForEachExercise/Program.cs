using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_ForEachExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sevenDwarves = {"Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy"};

            for (int i=0; i< sevenDwarves.Length; i++)
            {
                Console.WriteLine("Oi! " + sevenDwarves[i] + ", your dinner's ready mate.");
            }

            foreach (string i in sevenDwarves)
            {
                Console.WriteLine("Your drink is ready for you " + i + ".");
            }
        }
    }
}
