using PR_WebApp.Models;
using PayrollLibrary;

namespace PR_WebApp.Services
{
    using System;
    using System.Collections.Generic;

    public class EmployeeService
    {
        public List<Employee> Employees { get; set; }

        public EmployeeService(int count = 20)
        {
            Employees = new List<Employee>();
            GenerateRandomEmployees(count);
        }

        private void GenerateRandomEmployees(int count)
        {
            var random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2  == 0)
                {
                    // Generate a random HourlyEmployeeModel
                    Employees.Add(new HourlyEmployee(i, null, $"Employee {i}", $"employee{i}@example.com", "123-456-7890", 1, random.NextDouble() * 30, random.NextDouble() * 40));
                    
                }
                else
                {
                    // Generate a random SalariedEmployeeModel
                    Employees.Add(new SalariedEmployee(i, null, $"Employee {i}", $"employee{i}@example.com", "123-456-7890", 2, random.NextDouble() * 1000));
                }
            }
        }
    }


}
