namespace IndexersDemo
{
    public class Employee
    {
        public enum sample
        {
            _2 = 5,
            _3 = 5,
            _jack,
            _queen,
        }
        //Declare the properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }

        //Initialize the properties through constructor
        public Employee(int ID, string Name, string Job, int Salary, string Location,
                        string Department, string Gender)
        {
            this.ID = ID;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
            this.Location = Location;
            this.Department = Department;
            this.Gender = Gender;
        }

        public object this[string Name]
        {
            //The get accessor is used for returning a value
            get
            {
                if (Name == "ID")
                    return ID;
                else if (Name == "Name")
                    return this.Name;
                else if (Name == "Job")
                    return Job;
                else if (Name == "Salary")
                    return Salary;
                else if (Name == "Location")
                    return Location;
                else if (Name == "Department")
                    return Department;
                else if (Name == "Gender")
                    return Gender;
                else
                    return null;
            }

            // The set accessor is used to assigning a value
            set
            {
                if (Name == "ID")
                    ID = Convert.ToInt32(value);
                else if (Name == "Name")
                    this.Name = value.ToString();
                else if (Name == "Job")
                    Job = value.ToString();
                else if (Name == "Salary")
                    Salary = Convert.ToDouble(value);
                else if (Name == "Location")
                    Location = value.ToString();
                else if (Name == "Department")
                    Department = value.ToString();
                else if (Name == "Gender")
                    Gender = value.ToString();
            }
        }
    }
}