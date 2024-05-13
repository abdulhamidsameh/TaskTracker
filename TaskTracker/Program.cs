using System.Threading.Tasks;

namespace TaskTracker
{
	internal class Program
	{
		private static string[] Tasks = new string[100];

		private static int Counter = 0;

		private static void AddTask()
		{
			Console.Write("Enter The Task Title: ");
			string TaskTitle = Console.ReadLine()!;
			if (TaskTitle is not null)
			{
				Tasks[Counter++] = TaskTitle;
				Console.WriteLine("Task Added Successfuly");
			}
			else
				Console.WriteLine("Error Has Been Ocurred Please Try Again");
		}

		private static void RemoveTask()
		{
			Console.Write("Please Enter The Number Of Task You Wan't To Remove: ");
			string TaskNumber = Console.ReadLine()!;
			bool Flag = int.TryParse(TaskNumber, out int Number);
			if (Flag && Number > -1 && Number <= Counter - 1)
			{
				Tasks[Number-1] = null!;
				Console.WriteLine("Task Removed Successfully");
			}
			else
				Console.WriteLine("Error Has Been Ocurred Please Try Again");
		}

		private static void ShowAllTasks()
		{
			int Count = 1;
			for (int i = 0; i < Counter; i++)
				if (Tasks[i] is not null)
					Console.WriteLine($"{Count++}- {Tasks[i]}");
		}

		private static void CompleteTask()
		{
			Console.Write("Please Enter The Number Of Task You Wan't To Mark it as Complete: ");
			string TaskNumber = Console.ReadLine()!;
			bool Flag = int.TryParse(TaskNumber, out int Number);
			if (Flag && Number > -1 && Number <= Counter - 1 && Tasks[Number - 1] is not null)
			{
				Tasks[Number - 1] = $"{Tasks[Number - 1]}      COMPLETED";
				Console.WriteLine("Mark Task As Completed Successfully");
			}
			else
				Console.WriteLine("Error Has Been Ocurred Please Try Again");
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Welcome In My Task Tracker");
			do
			{
                Console.WriteLine("***********************************");
                Console.WriteLine("1- Add Task");
				Console.WriteLine("2- Show All Tasks");
				Console.WriteLine("3- Remove Task");
				Console.WriteLine("4- Mark Task As Completed");
				Console.WriteLine("5- Close Program");
				Console.Write("Please Select What You Want To Do: ");
				string ToDoNumber = Console.ReadLine()!;
				Console.Clear();
				switch (ToDoNumber)
				{
					case "1":
						AddTask();
						break;
					case "2":
						ShowAllTasks();
						break;
					case "3":
						RemoveTask();
						break;
					case "4":
						CompleteTask();
						break;
					case "5":
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Please Select Correct Number Between 1 to 5");
						break;
				}
			} while (true);
		}
	}
}
