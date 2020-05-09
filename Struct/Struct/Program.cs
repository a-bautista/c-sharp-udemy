using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            newEmployee.employeeName = "Alejandro";
            newEmployee.employeeJob = "SyteLine administrator";
            newEmployee.Salary = 5000;
            Console.WriteLine($"Employee name is {newEmployee.employeeName} and his job is {newEmployee.employeeJob}");
        }
    }

    struct Employee
    {
        public string employeeName;
        public string employeeJob;
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hi from the method in struct.");

        }
    }
}
