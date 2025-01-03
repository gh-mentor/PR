
using PR_WebApp.Models;
using PayrollLibrary;

namespace PR_WebApp.Services
{
    // Add a new class called 'DepartmentService'.
    // This class will have the following properties:
    // - Departments: A list of two DepartmentModel objects.
    // - Constructor: A parameterized constructor to initialize the properties.
    // - Departments: A public property to get or set the Departments list.
    public class DepartmentService
    {
        private List<Department> _Departments;

        public DepartmentService()
        {
            _Departments = new List<Department>
            {
                new Department(1, "IT"),
                new Department(2, "HR")
            };
        }

        public List<Department> Departments
        {
            get { return _Departments; }
            set { _Departments = value; }
        }
    }
}
