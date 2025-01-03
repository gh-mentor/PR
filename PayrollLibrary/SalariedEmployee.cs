namespace PayrollLibrary
{
    public class SalariedEmployee : Employee
    {
        private double _WeeklySalary;

        public double WeeklySalary
        {
            get { return _WeeklySalary; }
            set { _WeeklySalary = value; }
        }

        public SalariedEmployee(int? id, int? reportsTo, string name, string email, string mobile, int? departmentId, double weeklySalary)
            : base(id, reportsTo, name, email, mobile, departmentId)
        {
            _WeeklySalary = weeklySalary;
        }

        public override double Payment { get { return _WeeklySalary; } }

        // override the EmployeeDetails property
        public override string EmployeeDetails
        {
            get
            {
                return base.EmployeeDetails + $", Weekly Salary: {_WeeklySalary}";
            }
        }

    }
}
