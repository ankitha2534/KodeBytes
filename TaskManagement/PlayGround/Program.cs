using PlayGround.TaskManagement;

namespace PlayGround
{
    public class Program
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        /// <remarks>
        /// The method display menu for user to perform operations like add, view, edit, delete on a task
        /// </remarks>
        public static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            bool isValid = true;
            while (isValid)
            {
                ShowMenu();
                if (int.TryParse(Console.ReadLine(), out int userChoice) && userChoice < 5 && userChoice > 0)
                {
                    switch (userChoice)
                    {
                        case 1:
                            taskManager.AddTask();
                            break;
                        case 2:
                            taskManager.ViewTasks();
                            break;
                        case 3:
                            taskManager.EditTask();
                            break;
                        case 4:
                            taskManager.DeleteTask();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    isValid = false;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option");
                    Console.WriteLine("Press any key to terminate");
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Static method that displays menu
        /// </summary>
        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Task manager menu : ");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Edit Task");
            Console.WriteLine("4. Delete Task");
        }

    }
}
