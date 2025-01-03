namespace PayrollLibrary
{
    public class HourlyEmployee : Employee
    {
        private double _HourlyRate;
        private double _HoursWorked;

        public double HourlyRate
        {
            get { return _HourlyRate; }
            set { _HourlyRate = value; }
        }

        public double HoursWorked
        {
            get { return _HoursWorked; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours worked cannot be negative.");
                }
                _HoursWorked = value;
            }
        }

        public HourlyEmployee(int? id, int? reportsTo, string? name, string? email, string? mobile, int? departmentId, double hourlyRate = 0, double hoursWorked = 0)
            : base(id, reportsTo, name, email, mobile, departmentId)
        {
            _HourlyRate = hourlyRate;
            _HoursWorked = hoursWorked;
        }

        // Add a default constructor
        public HourlyEmployee() : base(null, null, null, null, null, null) { }

        public override double Payment => _HourlyRate * _HoursWorked;

        // override the EmployeeDetails property
        public override string EmployeeDetails => base.EmployeeDetails + $", Hourly Rate: {_HourlyRate}, Hours Worked: {_HoursWorked}";
    }
}
