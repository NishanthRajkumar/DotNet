using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationDeserialization
{
    class GlobalClass
    {
        internal static Employee CreateEmployeeObject()
        {
            Employee emp = new Employee();
            emp.FirstName = "Vianyak";
            emp.LastName = "Ushakola";
            emp.MobileNo = 9876543210;
            emp.Email = "vinayak@gmail.com";
            emp.Designation = "Software Developer";
            emp.Department = "IT";
            return emp;
        }
    }
}
