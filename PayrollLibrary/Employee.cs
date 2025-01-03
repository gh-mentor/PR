namespace PayrollLibrary
{

    public abstract class Employee
    {
        private int? _Id;
        private int? _ReportsTo;
        private string? _Name;
        private string? _Email;
        private string? _Mobile;
        private int? _DepartmentId;

        public int? Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int? ReportsTo
        {
            get { return _ReportsTo; }
            set { _ReportsTo = value; }
        }

        public string? Name
        {
            get { return _Name; }
            set { _Name = value!; }
        }

        public string? Email
        {
            get { return _Email; }
            set { _Email = value!; }
        }
        public string? Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value!; }
        }

        public int? DepartmentId
        {
            get { return _DepartmentId; }
            set { _DepartmentId = value; }
        }


        // add a default c'to
        public Employee() { }
        public Employee(int? id, int? reportsTo, string? name, string? email, string? mobile, int? departmentId)
        {
            _Id = id;
            _ReportsTo = reportsTo;
            _Name = name;
            _Email = email;
            _Mobile = mobile;
            _DepartmentId = departmentId;
        }

        public abstract double Payment { get; }

        public virtual string EmployeeDetails
        {
            get { return $"Id: {_Id}, Name: {_Name}, Email: {_Email}, Mobile: {_Mobile}, DepartmentId: {_DepartmentId}"; }
        }

    }
  
}
