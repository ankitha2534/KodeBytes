namespace PlayGround.TaskManagement
{
    public class TaskManager
    {
        static List<string> tasks = new List<string>();

        /// <summary>
        /// Method to add taask
        /// </summary>
        /// <remarks>
        /// This asks user input of string type and add task to the tasks list and check whether task is empty or not
        /// </remarks>
        public void AddTask()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your Task :");
            string? task = Console.ReadLine();
            if (!string.IsNullOrEmpty(task))
            {
                tasks.Add(task);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Task added successfully");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Task should not be empty!");
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Method that displays all tasks
        /// </summary>
        /// <remarks>
        /// If list is empty display no task added
        /// </remarks>
        public void ViewTasks()
        {
            Console.WriteLine();
            if (tasks.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("All tasks : ");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{tasks[i]}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No tasks added");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method to update a task
        /// </summary>
        /// <remarks>
        /// Take taskId as user input of integer type and if taskId is valid then this method will update task successfully otherwise display message as invalid taskId  and check whether task is empty or not.
        /// </remarks>
        public void EditTask()
        {
            ViewTasks();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter task id from above list of tasks to update : ");
            if (int.TryParse(Console.ReadLine(), out int taskId) && taskId > 0 && taskId <= tasks.Count)
            {
                string? task = Console.ReadLine();
                if (!string.IsNullOrEmpty(task))
                {
                    tasks[taskId - 1] = task;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Task updated successfully");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Task should not be empty!");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid taskId");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Method to delete task
        /// </summary>
        /// <remarks>
        /// Take taskId as user input of integer type and if taskId is valid then this method will delete particular task successfully otherwise display message as invalid taskId.
        /// </remarks>
        public void DeleteTask()
        {
            ViewTasks();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter task id from above list of tasks to delete : ");
            if (int.TryParse(Console.ReadLine(), out int taskId) && taskId > 0 && taskId <= tasks.Count)
            {
                tasks.RemoveAt(taskId - 1);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Task deleted successfully");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid taskId");
                Console.WriteLine();
            }
        }
    }
}
