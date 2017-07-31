using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_DoWhileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you solve the riddles?");
            Console.WriteLine("I don't have eyes, but once I did see. Once I had thoughts, but now I'm white and empty.");
            string response = (Console.ReadLine()).ToLower();
            int numGuesses = 1;
            

            while (response != "skull")
            {
                numGuesses++;
                Console.WriteLine("Try again");
                Console.WriteLine("I don't have eyes, but once I did see. Once I had thoughts, but now I'm white and empty.");
                response = (Console.ReadLine()).ToLower();
            }

            if (response == "skull")
            {
                Console.WriteLine("Correct!");
            }


            do
            {
                Console.WriteLine("What has a Heart but no other organs?");
                response = (Console.ReadLine()).ToLower();
                if (response != "A deck of cards")
                {
                    Console.WriteLine("Try again");
                    
                }
            } while (response != "A deck of cards");
            Console.WriteLine("Correct!");
    
        }
    }
}
