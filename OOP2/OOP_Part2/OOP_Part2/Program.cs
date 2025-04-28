using OOP_Part2;

namespace OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car()
            {
                Accerlation = 100,
                DoorCount =5,
                BreakSpeed=50,
                Speed=300

            };
            Plane plane = new Plane()
            {
                Accerlation = 500,
                DoorCount = 10,
                BreakSpeed = 200,
                Speed = 3000,
                HasJetDrive = true
            };

        }
    }
}