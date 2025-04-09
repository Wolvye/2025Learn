using System;
using System.IO; // IO = Input Output


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Create File
            string path = "test.txt";
            //    //File.Create(path);

            //    // Read File
            //   string content =  File.ReadAllText(path);
            //    Console.WriteLine(content);

            //Copy File mit kleiner Absicherung
            //if (File.Exists(path))
            //{
            //    string destinationPath = "Test2.txt";
            //    File.Copy(path, destinationPath);

            //}
            //else
            //{
            //    Console.WriteLine("Can not find file");

            //    FileStream fs = File.Create(path);
            //    fs.Close();

            //    Console.WriteLine("Path created");
            //    File.WriteAllText(path, "Nix Los");
            //}

            //Append anfügen
            //if (File.Exists(path))
            //{
            //    File.AppendAllText(path, "I'm Batman!");
            //}

            //Delete
            if (File.Exists(path))
            { 
                File.Delete(path);
            }


        }
    }
}