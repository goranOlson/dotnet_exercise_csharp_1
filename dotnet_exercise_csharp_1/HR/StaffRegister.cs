namespace dotnet_exercise_csharp_1.HR
{
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
}
