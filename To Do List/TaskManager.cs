using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do_List
{
     class TaskManager
    {

        private List<string> tasks = new List<string>();

        public void AddTask()
        {
            Console.Write("Enter task: ");
            string task = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(task))
            {
                Console.WriteLine("Task cannot be empty.");
                return;
            }

            tasks.Add(task);
            Console.WriteLine("Task added successfully.");
        }

        public void ShowTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("\n===== TASKS =====");

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        public void RemoveTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to remove.");
                return;
            }

            ShowTasks();

            Console.Write("\nEnter task number: ");

            if (!int.TryParse(Console.ReadLine(), out int index))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (index < 1 || index > tasks.Count)
            {
                Console.WriteLine("Task not found.");
                return;
            }

            string removed = tasks[index - 1];

            tasks.RemoveAt(index - 1);

            Console.WriteLine($"Removed: {removed}");
        }

        public void SortTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to sort.");
                return;
            }

            tasks.Sort();

            Console.WriteLine("Tasks sorted.");
        }
    }
}
