using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Part2
{
    abstract class Vehicle
    {
        public float Speed { get; set; }
        public float Accerlation { get; set; }
        public float BreakSpeed { get; set; }
        public int DoorCount { get; set; }

        public void LogInformation()
        {
            Console.WriteLine("Das Fahrzeug fährt mit " + Speed + " km/h");
        }

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

    }
}
