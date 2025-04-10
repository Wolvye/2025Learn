using System;
using System.IO; // IO = Input Output


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Create File
            //string path = "test.txt";
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
            //if (File.Exists(path))
            //{ 
            //    File.Delete(path);
            //}

            //string path = "files/";
            //string fileName = "text.txt";

            //if (Directory.Exists(path))
            //{
            //    Console.WriteLine("Ordner existiert");
            //}
            //else
            //{
            //    Directory.CreateDirectory(path);
            //}
            //// Get files
            //var filesInDir = Directory.GetFiles(path);
            //for(int i = 0; i < filesInDir.Length; i++) 
            //{
            //    Console.WriteLine(filesInDir[i]);
            //}

            ////Get Ordner
            //var dirInDir = Directory.GetDirectories(path);
            //for (int i = 0; i < filesInDir.Length; i++)
            //{
            //    Console.WriteLine(dirInDir[i]);
            //}
            ////wo befinden wir uns
            //var currentPath = Directory.GetCurrentDirectory();
            //Console.WriteLine(currentPath);

            //Environment Ordner die man so kennt, sowas wie auf dem Desktop (aber der Wert ist eine Zahl)
            // string path =Environment.SpecialFolder.(Environment.SpecialFolder.Desktop) + "/files";

            //mit direkten Pfad (zB aus dem Explorer) Muss man ein @ vorsetzen
            // string path = @"C:\Users\Files\files";

            //PathKlasse
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +  "/files";
            //string fileName = "text.txt";

            //string finalPath = Path.Combine(path, fileName);
            //Console.WriteLine(finalPath); // Valide, da \ erstellt werden in dem String
            //Console.WriteLine(path + fileName); // wird nur angehängt, also nicht valide

            ////Hol MP3 Datein aus einem Ordner:
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/files";
            //string[] files = Directory.GetFiles(path);
            //for (int i = 0; i < files.Length; i++)
            //{
            //    Console.WriteLine(files[i]); //schauen, welche Dateien da sind
            //    var ext = Path.GetExtension(files[i]);
            //    Console.WriteLine(ext); //schauen welche extension drinne sind

            //}



        }
    }
}