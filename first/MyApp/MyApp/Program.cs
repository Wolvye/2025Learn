﻿namespace MyApp
{ //Wiederholung der Basics
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Wie heißt du? ");
            string name = Console.ReadLine();

            Console.WriteLine("Wie alt bist du?");
            string age = Console.ReadLine();
            int birthYear = 2025 - int.Parse(age);
            Console.WriteLine("Dein name ist" + " " + name + " " + "und du im Jahre" + " " + birthYear + " " + "geboren");
           

            //Arrays


            int[] numbers = new int[5];
            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;
            numbers[3] = 800;
            numbers[4] = 400;

            Array.Sort(numbers);

            //Schleifen
           
            int result = 0;
            foreach (int n in numbers)
            {
                result += n;
                
            }
            Console.WriteLine(result);

            for (int i = 0; i<numbers.Length; i++) 
            {
                result += numbers[i];
            }
            Console.WriteLine(result);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            
            for (int i = 2; i <= 20; i+=2)
            {
                Console.WriteLine(i);
            }
            

            for (int i = 10; i>=1; i--)
            {
                Console.WriteLine(i);
            }
            
            int[] numbers2 = new int[3] { 5, 10, -4 };
            int i = 0;
            while (i < numbers2.Length)
            {
              
                Console.WriteLine(numbers2[i]);
                i++;
        }
             */
            //Guess Game
            /*
            Random random = new Random();
            int secretNumber = random.Next(1,11);
            int UserGuess = 0;
            while (UserGuess != secretNumber)
            {
                Console.WriteLine("Rate welche Zahl ich bin, zwischen 1 und 10");
                UserGuess = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Das war die richtige Zahl!");
            */

            //Aufgabe: Erstelle ein Programm, dass den Nutzer 5x nach einer Zahleneingabe fragt
            //speichere die Werte in einem Arrayy mit 5 Pätzen
            //Berechne zum Schluss die Summe aller Zahlen, die vom Nutzer eingegeben werden

            float[] NutzerEingabeArray = new float[5];
            float zwischenspeicher = 0;
            for (int i = 0; i <= 4; i++)
            {
                
                Console.WriteLine("Bitte gib die " + (i+1) + " Zahl ein.");
                zwischenspeicher=float.Parse( Console.ReadLine());
                NutzerEingabeArray[i] = zwischenspeicher;
          
            }
            float result = 0;
            foreach (float item in NutzerEingabeArray)
            {
               result += item;
            }
            Console.WriteLine("Die Summe ist: " + result);

        }
    }
}
