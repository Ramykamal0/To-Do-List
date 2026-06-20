using System;
using System.Collections.Generic;

namespace To_Do_List
{

    class Program
    {
        static void Main()
        {
            TaskManager todo = new TaskManager();

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n========================");
                Console.WriteLine("      TO DO LIST");
                Console.WriteLine("========================");
                Console.WriteLine("1 - Add Task");
                Console.WriteLine("2 - Remove Task");
                Console.WriteLine("3 - Show Tasks");
                Console.WriteLine("4 - Sort Tasks");
                Console.WriteLine("5 - Exit");

                Console.Write("\nChoose: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Numbers only.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        todo.AddTask();
                        break;

                    case 2:
                        todo.RemoveTask();
                        break;

                    case 3:
                        todo.ShowTasks();
                        break;

                    case 4:
                        todo.SortTasks();
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("Goodbye.");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}