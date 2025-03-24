using System.ComponentModel;
using System.ComponentModel.Design;

namespace thrid
{
    internal class Program
    {
        static void Main(string[] args)
        {/*

            //Anwendung: Todo List
            // was brauche ich ?
            // Add,View,Delete,Quit

            string[] todoList = new string[10];
            int currentTaskCount = 0;
            string command = "";

            while (command != "quit")
            {
                Console.WriteLine("Please enter a command (add, view,delete,quit): ");
                command = Console.ReadLine().ToLower();
                
            if (command == "add")
                {
                    if (currentTaskCount < todoList.Length)
                    {
                        Console.WriteLine("Please enter a task to add: ");
                        string task = Console.ReadLine();
                        todoList[currentTaskCount] = task;
                        currentTaskCount++;
                    }
                    else
                    {
                        Console.WriteLine("Todo list is full.");
                    }
                }
                else if (command == "view")
                {
                    Console.WriteLine("Your current tasks are:");

                    for (int i = 0; i < currentTaskCount; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + todoList[i]);
                    }
                }
                else if(command == "delete")
                {
                    Console.WriteLine("Please enter the number of the task to delete");
                    int taskNumber = int.Parse(Console.ReadLine())-1;

                    if (taskNumber < 0 || taskNumber >= currentTaskCount)
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                    else 
                    {//hier wird nicht direkt gelöscht, sondern die Liste wird verschoben
                     //auf das alte Element
                        for (int i = taskNumber; i < currentTaskCount - 1; i++)
                        {
                            todoList[i] = todoList[i + 1];
                        }
                        currentTaskCount--;
                        Console.WriteLine("Task removed.");
                    }
                }else if (command == "quit")
                {
                    Console.WriteLine("Good Bye");
                }
            

            //was brauche ich ?
            // Add,View,Delete,Quit
            //ohne stützräder

            string[] ToDoList = new string[5];
            string command = "";
            int zähler = 0;

            while (command != "quit")
            {
                Console.WriteLine("Gib einer der folgenden Komandos ein Add,View,Delete,Quit");
                command = Console.ReadLine().ToLower();


                if (command == "add")
                {
                    if (zähler <= 5)
                    {
                        Console.WriteLine("Bitte gib was in deine Liste ein");
                        string aufgabe = Console.ReadLine();
                        ToDoList[zähler] = aufgabe;
                        zähler++;
                    }
                    else
                    {
                        Console.WriteLine("Deine ToDoListe ist voll");
                    }

                }
                else if (command == "view")
                {
                    Console.WriteLine("Deine Aktuelle Liste: ");

                    for (int i = 0; i <= zähler; i++)
                    {
                        Console.WriteLine(ToDoList[i]);
                    }
                }

                else if (command == "delete")
                {
                    Console.WriteLine("was soll gelöscht werden?");
                    int aufgabenZähler = int.Parse(Console.ReadLine()) - 1;

                    if (aufgabenZähler < 0 || aufgabenZähler >= zähler)
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                    else
                    {
                        for (int i = aufgabenZähler; i < zähler - 1; i++)
                        {
                            ToDoList[i] = ToDoList[i + 1];
                        }
                        ToDoList[zähler - 1] = null;
                        zähler--;
                        Console.WriteLine("Task removed.");
                    }
                }

            }
            if (command == "quit")
            {
                Console.WriteLine("Ciao Kakao!");
            }


            */
            //Reserviere ein Wort - dreh es um!
            /*
            string rueckwaertsWort = "";
            Console.WriteLine("Bitte gib etwas ein, das wird rückwärts zurück gegeben");
            rueckwaertsWort = Console.ReadLine();
            rueckwaertsWort = String.Concat(rueckwaertsWort.Reverse());
            Console.WriteLine(rueckwaertsWort);
            */

        }
    }
}
