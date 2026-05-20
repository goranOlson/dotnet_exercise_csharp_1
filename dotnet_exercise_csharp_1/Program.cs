namespace dotnet_exercise_csharp_1
{
    class Employee
    {
        private string name;
        private int salary;

        public Employee(string employeeName, int employeeSalary)
        {
            name = employeeName;
            salary = employeeSalary;
        }

        public void printInfo()
        {
            Console.WriteLine($"Name: {name}, Salary: {salary}");
        }
    }

    class StaffRegister
    {
        private List<Employee> StaffList = new List<Employee>();

        public void AddEmployee()
        {
            int salary = -1;

            Console.WriteLine("");
            Console.WriteLine("____Add new employee-___");
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Enter employee salary: ");
            string salaryInput = Console.ReadLine() ?? "";

            int.TryParse(salaryInput, out salary);

            if (name != "" && salary > 0)
            {
                Employee newEmployee = new Employee(name, salary);
                StaffList.Add(newEmployee);
                Console.WriteLine("");
                Console.WriteLine("New employee added successfully!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid data - could not create new employee!");
            }
        }
        public void PrintEmployeeList()
        {
            Console.WriteLine("");
            Console.WriteLine("     Employee List");
            Console.WriteLine("--------------------------");

            if(StaffList.Count > 0)
            {
                foreach (var employee in StaffList)
                {
                    employee.printInfo();
                }
            }
            else
            {
                Console.WriteLine("       Empty list");
            }

            Console.WriteLine("--------------------------");
            // Console.WriteLine("");
        }
    }

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
