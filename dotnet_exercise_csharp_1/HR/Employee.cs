namespace dotnet_exercise_csharp_1.HR
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
}
