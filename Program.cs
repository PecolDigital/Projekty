using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>(); 
            string command;

            Console.WriteLine("To-Do List");

            do
            {
                Console.WriteLine("\nWybierz opcję:");
                Console.WriteLine("1 - Dodaj zadanie");
                Console.WriteLine("2 - Usuń zadanie");
                Console.WriteLine("3 - Pokaż wszystkie zadania");
                Console.WriteLine("4 - Zakończ");

                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        Console.Write("Wpisz zadanie: ");
                        string task = Console.ReadLine();
                        tasks.Add(task);
                        Console.WriteLine("Zadanie dodane.");
                        break;
                    case "2":
                        Console.Write("Wpisz numer zadania do usunięcia: ");
                        int taskNumber = Convert.ToInt32(Console.ReadLine());
                        if (taskNumber > 0 && taskNumber <= tasks.Count)
                        {
                            tasks.RemoveAt(taskNumber - 1);
                            Console.WriteLine("Zadanie usunięte.");
                        }
                        else
                        {
                            Console.WriteLine("Nie ma takiego zadania.");
                        }
                        break;
                    case "3":
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Brak zadań.");
                        }
                        else
                        {
                            Console.WriteLine("Lista zadań:");
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Koniec.");
                        break;
                    default:
                        Console.WriteLine("Błąd.");
                        break;
                }

            } while (command != "4");

            Console.ReadKey();
        }
    }
}
