using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_UserInput_CreateCars
{
    class Program
    {
        static void Main(string[] args)
        {
         
            List<Car> carsList = new List<Car>();

            do
            {
                Console.WriteLine("Please type A to add a car, or X to exit:");
                string response = Console.ReadLine().ToUpper();
                if (response == "A")
                {
                    Console.WriteLine("Please enter a car make:");
                    make = Console.ReadLine();
                    Console.WriteLine("Please enter a car model:");
                    model = Console.ReadLine();
                    Console.WriteLine("Please enter a car price:");
                    price = Convert.ToInt32(Console.ReadLine());

                    Car myCar = new Car(make, model, price);
                    carsList.Add(myCar);

                    Console.WriteLine("\nHere is the current list of cars: \n");
                    foreach(Car c in carsList)
                    {
                        Console.WriteLine("Make: {0}", c.make);
                    }
                }

            } while (response != "X");
            
        }
    }
}
