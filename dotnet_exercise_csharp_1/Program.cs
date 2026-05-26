using dotnet_exercise_csharp_1.HR;

namespace dotnet_exercise_csharp_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            StaffRegister Register = new StaffRegister();

            int choice = -1;

            do
            {
                choice = PrintMainMenu();

                switch (choice)
                {
                    case 1:
                        Register.AddEmployee();
                        break;
                    case 2:
                        Register.PrintEmployeeList();
                        break;
                    case 0:
                        Console.WriteLine("");
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            while (choice != 0);
        }

        static int PrintMainMenu()
        {
            //int choice = -1;
            string input = "";
            int value = -1;
            bool isValidInput = false;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("       Main menu       ");
                Console.WriteLine("=======================");
                Console.WriteLine("1: Add Employee");
                Console.WriteLine("2: Print Employees");
                Console.WriteLine("0: Exit");
                Console.Write("Enter your choice: ");

                input = Console.ReadLine() ?? "";

                if (int.TryParse(input, out value))
                {
                    if (value >= 0 && value <= 2)
                    {
                        isValidInput = true;
                    }
                }

                if (!isValidInput)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid choice. Please enter 1 or 2. Exit with 0.");
                    Console.WriteLine("");
                }
            }
            while (isValidInput != true);
            
            return value;
        }
    }
}
