using SwitchesEnum;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Switches
            Console.WriteLine("Bitte geben Sie einen Wochentag ein (1-7): ");

            int day = int.Parse(Console.ReadLine());

          switch (day)
            {
                case 1:
                    Console.WriteLine("Montag");
                    break;
                case 2:
                    Console.WriteLine("Dienstag");
                    break;
                case 3:
                    Console.WriteLine("Mittwoch");
                    break;
                case 4:
                    Console.WriteLine("Donnerstag");
                    break;
                case 5:
                    Console.WriteLine("Freitag");
                    break;
                case 6:
                    Console.WriteLine("Samstag");
                    break;
                case 7:
                    Console.WriteLine("Sonntag");
                    break;
                default:
                    Console.WriteLine("Ungülige Eingabe");
                    break;
            */



            //Enums

            Console.WriteLine("Welche Auflösung möchten sie? ( 720 , 1920 ,3840)");

            int resolution = int.Parse(Console.ReadLine());
            Resolutions myResolution = (Resolutions)resolution;

            switch (myResolution)
            {
                case Resolutions.SD:
                    Console.WriteLine("Standard");
                    break;
                case Resolutions.HD:
                    Console.WriteLine("HD");
                    break;
                case Resolutions.UHD:
                    Console.WriteLine("UHD");
                    break;
            }

        }
    }
}