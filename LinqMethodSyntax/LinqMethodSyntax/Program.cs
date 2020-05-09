using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace LinqMethodSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var filteredList = new List<Employee>();
            var listOfEmployees = new List<Employee>
            {
                new Employee {EmployeeID=1150, FirstName="Orlando", LastName="Ramos", Salary=5000m, Age=29, Appraisal=new List<int>{ 7, 7, 8, 7, 8} },
                new Employee {EmployeeID=1250, FirstName="Esteban", LastName="Zenteno", Salary=10000m, Age=40, Appraisal=new List<int>{ 2, 5, 6, 5, 6} },
                new Employee {EmployeeID=1350, FirstName="Michael", LastName="Hook", Salary=7000m, Age=25, Appraisal=new List<int>{ 9, 4, 7, 8, 7} },
                new Employee {EmployeeID=1450, FirstName="Jeremy", LastName="Jackson", Salary=6000m, Age=34, Appraisal=new List<int>{ 6, 4, 5, 9, 5} },
                new Employee {EmployeeID=1550, FirstName="Sebastien", LastName="Lacroix", Salary=9000m, Age=39, Appraisal=new List<int>{ 8, 4, 7, 9, 8} }
            };

            Employee.DisplayWithAppraisal(listOfEmployees, "All Employees");


            // LINQ method syntax
            // salary is greater than or equal to 6000 and age greater than 40
            filteredList = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age >= 40).ToList();

            // LINQ method syntax
            // salary is greater than or equal to 8000 or age greater than 35 (using LINQ)
            filteredList = listOfEmployees.Where(e => e.Salary >= 8000 || e.Age > 35).ToList();

            Console.WriteLine("Employees that have a salary greater than 6000 and are equal to 40 or older " +
                "and Employees that have a salary greater than 8000 or age older than 35:\n");
            foreach (var employee in filteredList)
            {
                Console.WriteLine(employee.FirstName + " "+ employee.LastName);
            }

            // salary is greater than 4000 and last appraisal is less than 8
            filteredList = listOfEmployees.Where(e => e.Salary >= 4000).ToList();


            // My solution
            filteredList = listOfEmployees.Where(e => e.Salary>4000).ToList();
            Console.WriteLine("Display the employees with a salary greater than 4000 and the last value " +
                "of the appraisal less than 8");
            foreach (var employee in listOfEmployees)
            {
                for (int i = 0; i < employee.Appraisal.Count; i++)
                {
                    if (i == 4 && employee.Appraisal[i] < 8) 
                    {
                        Console.WriteLine(employee.FirstName + " " + employee.LastName);
                        Console.WriteLine(employee.Appraisal[i]);
                    }
                }
                
            }

            // Mohey's solution
            filteredList = listOfEmployees.Where(e => e.Salary > 4000 && e.Appraisal[4] < 8).ToList();
            Employee.DisplayWithAppraisal(filteredList, "Last appraisal less than 8 and salary greater than 4000");

            // LINQ query syntax
            // Salary is greater than or equal to 6000 and age greater than 40
            filteredList = (from emp in listOfEmployees
                            where emp.Salary >= 6000 && emp.Age >= 40
                            select emp).ToList();
            Employee.DisplayWithAppraisal(filteredList, "Salary higher than 6000 and age above 40");

            filteredList = (from emp in listOfEmployees
                            where emp.Salary >= 4000 && emp.Appraisal[4] < 8
                            select emp).ToList();

            Employee.DisplayWithAppraisal(filteredList, "Salary higher than 4000 and last appraisal less than 8");

            Employee.DisplayWithAppraisal(listOfEmployees, "Before sorting");

            Employee.DisplayWithAppraisal(SortEmployees(listOfEmployees), "After sorting");

            /*
            string xmlText = string.Empty;
            XmlSerializer xmlWriter = new XmlSerializer(typeof(List<Employee>));
            using (StringWriter sw = new StringWriter())
            {
                xmlWriter.Serialize(sw, listOfEmployees);
                Console.WriteLine(sw.ToString());
            }
            */

        }

        public static List<Employee> SortEmployees(List<Employee> employees)
        {
            var list = from emp in employees
                       orderby emp.Age descending
                       select emp;
            return list.ToList();
        }
    }
}
