using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, I will create a car for you!");
            Car rentalCar = new Car("Honda Accord", 4);
            Console.WriteLine("Here you go, a new " + rentalCar.Doors + "-door " + rentalCar.Model);
            Console.ReadLine();
            rentalCar.Passengers.Add("Bob");
            rentalCar.Passengers.Add("Sherry");
            Console.WriteLine("Whoops, looks like there are people already in it. Do you want to remove them? (Y/N)");
            string answer = Console.ReadLine();
            if(answer.ToUpper() == "Y")
            {
                rentalCar.Passengers.Clear();
            }
            Console.WriteLine("Ok. Your car is ready! It contains " + rentalCar.Passengers.Count + " passengers.");
        }
    }
}
