using OOP_Part2;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            Console.WriteLine("Welches Fahrzeug möchtest du fahren?");

            var userInput = Console.ReadLine();


            Car car = new Car()
            {
                Accerlation = 100,
                DoorCount = 5,
                BreakSpeed = 50,
                Speed = 300

            };

            Plane plane = new Plane()
            {
                Accerlation = 500,
                DoorCount = 10,
                BreakSpeed = 200,
                Speed = 3000,
                HasJetDrive = true
            };

            Motorcycle motorcycle = new Motorcycle()
            {
                Accerlation = 200,
                DoorCount = 0,
                BreakSpeed = 30,
                Speed = 400,
            };
            vehicles.Add(car);
            vehicles.Add(plane);
            vehicles.Add(motorcycle);


            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.GetType().Name == userInput)
                {
                    Console.WriteLine("Fahrzeug gefunden" + userInput);
                    vehicle.LogInformation();
                    if (userInput == "Car")
                    {
                        Car myCar = vehicle as Car;
                       
                        myCar.Move();

                    } else if (userInput == "Plane")
                    {
                        Plane myPlane = vehicle as Plane;
                        
                        myPlane.Move();

                    } else if (userInput == "Motorcycle")
                    {
                        Motorcycle myMotorcycle = vehicle as Motorcycle;
                        
                        myMotorcycle.Move();

                    }else
                    {
                        Console.WriteLine("Fahrzeug steht nicht zur Verfügung");
                    }

                        break;
                }
            }
        }
    }
}