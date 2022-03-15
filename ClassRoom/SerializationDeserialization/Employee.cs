using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationDeserialization
{
    [Serializable]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long MobileNo { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
    }
}
