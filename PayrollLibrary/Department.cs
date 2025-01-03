/*
This file contains the 'Department' class. This class is used to store information about Acme corporation departments.
A department has an id, name, and owns  a collection of employees.
*/

using System.Collections.Generic;
using System;


namespace PayrollLibrary
{
    public class Department
    {
        private int _Id;
        private string _Name;
        private List<Employee> _Employees;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public List<Employee> Employees
        {
            get { return _Employees; }
        }

        public Department(int id, string name)
        {
            _Id = id;
            _Name = name;
            _Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _Employees.Add(employee);
        }

        public override string ToString()
        {
            return $"Department: {_Name}";
        }
    }
}