using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_IfCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int myNumber = 7;

            int response = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 10. Please guess my number:");

            while (response != myNumber)
            {

                response = Convert.ToInt32(Console.ReadLine());

                if (response > myNumber)
                {
                    Console.WriteLine("Too high! Try again:" + response);


                }
                else if (response < myNumber)
                {
                    Console.WriteLine("Too low! Try again:" + response);

                }
            }

            Console.WriteLine("Congrats! You guessed right!");
        }
    }
}
