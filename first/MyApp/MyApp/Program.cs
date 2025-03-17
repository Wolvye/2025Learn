namespace MyApp
{ //Wiederholung der Basics
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie heißt du? ");
            string name = Console.ReadLine();

            Console.WriteLine("Wie alt bist du?");
            string age = Console.ReadLine();
            int birthYear = 2025 -int.Parse(age);
            Console.WriteLine("Dein name ist" + " " + name +" "+ "und du im Jahre"+" " + birthYear +   " " +"geboren");
        }
    }
}
