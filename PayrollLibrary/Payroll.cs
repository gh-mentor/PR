
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary
{
    public class Payroll
    {
        /// <summary>
        /// Processes the employees of the given company and prints their payment details.
        /// </summary>
        /// <param name="company">The company whose employees will be processed.</param>
        public void ProcessEmployees(Company company)
        {
            foreach (var department in company.Departments)
            {
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine($"{employee.EmployeeDetails}, Payment: {employee.Payment}");

                }
            }
        }
    }
}
