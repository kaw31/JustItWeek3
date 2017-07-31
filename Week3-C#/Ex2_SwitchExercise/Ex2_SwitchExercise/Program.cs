using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_SwitchExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose your favourite film, from the following... Pulp Fiction, Inception, The Dark Knight, The Notebook, Toy Story");
            string favFilm = Console.ReadLine();

            switch (favFilm)
            {
                case "Pulp Fiction":
                    Console.WriteLine("Excellent choice!");
                    break;
                case "Inception":
                case "The Dark Knight":
                    Console.WriteLine("Brilliant choice. Nolan is great");
                    break;
                case "The Notebook":
                    Console.WriteLine("What's wrong with you? Awful choice");
                    break;
                case "Toy Story":
                    Console.WriteLine("Childhood classic!");
                    break;
                default:
                    Console.WriteLine("Not on the list");
                    break;
            }
            
        }
    }
}
