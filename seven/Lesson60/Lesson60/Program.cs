using Lesson60;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Aufgabe Erstelle ein Programm mit einer Liste von Stundenten
             * Verwende für den Stunden eine Klasse
             * Jeder Student hat einen NC
             * Berechne dann den durschschnittlichen NC aller Studenten mit einer Schleife
             */
            //Ohne Stützräder geschafft <3


         
     
            List<Student> names = new List<Student>();
           
            Student JohnDoe = new Student ("John","Doe","Leichenhalle",9,5);
            Student JohnWick = new Student("John", "Wick", "Hotelstraße", 4, 10);
            Student JohnCloude = new Student("John", "Cloude", "IrgendwoInFrance", 3, 7);

            Student AngiJoe = new Student("Angi", "Joe", "IrgendwoInHollyWood", 2, 9);
            Student Libby = new Student("Libby", "Miller", "MirEgalWo", 13, 1);
            Student Nami = new Student("Nami", "Strohhut", "EastBlue", 2, 4);

            names.Add(JohnDoe);
            names.Add(JohnWick);
            names.Add(JohnCloude);
            names.Add(AngiJoe);
            names.Add(Libby);
            names.Add(Nami);

            //forschleife hier
            float count = names.Count;
            Console.WriteLine(count);
            foreach (Student student in names)
            {
                float average = student.nC + student.nC/count;
                Console.WriteLine(average);
                break;
            }

        }
    }
}