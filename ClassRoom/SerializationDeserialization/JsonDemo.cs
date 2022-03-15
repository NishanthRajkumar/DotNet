using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SerializationDeserialization
{
    class JsonDemo
    {
        string path1 = Directory.GetCurrentDirectory() + @"\JsonFile1.json";
        string path2 = Directory.GetCurrentDirectory() + @"\JsonFile2.json";

        internal void ConvertObjectToJsonAndSave()
        {
            Employee employee = GlobalClass.CreateEmployeeObject();

            JsonSerializer serializer = new JsonSerializer();

            Console.WriteLine("***ConvertObjectToJsonAndSave***");
            using (StreamWriter sw = new StreamWriter(path1))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, employee);
            }

            string txt = File.ReadAllText(path1);
            Console.WriteLine(txt);
            Console.WriteLine("\n=====================================================\n");
        }



        internal void ConvertJsonToObject()
        {
            var text = File.ReadAllText(path1);
            var objEmp = JsonConvert.DeserializeObject<dynamic>(text);
            Console.WriteLine("***ConvertJsonToObject***");
            Console.WriteLine(objEmp.FirstName);
            Console.WriteLine(objEmp.LastName);
            Console.WriteLine(objEmp.MobileNo);
            Console.WriteLine(objEmp.Email);
            Console.WriteLine(objEmp.Designation);
            Console.WriteLine(objEmp.Department);
            Console.WriteLine("\n=====================================================\n");
        }

        internal void ConvertlstOfObjectToJsonAndSave()
        {
            Employee employee = GlobalClass.CreateEmployeeObject();
            Employee employee2 = new Employee();
            employee2.FirstName = "Ravi";
            employee2.LastName = "Sonkar";
            employee2.MobileNo = 1234567890;
            employee2.Email = "ravi@gmail.com";
            employee2.Designation = "Software Developer";
            employee2.Department = "IT";

            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();

            List<Employee> lstOfEmployees = new List<Employee>();
            lstOfEmployees.Add(employee);
            lstOfEmployees.Add(employee2);

            Console.WriteLine("***ConvertlstOfObjectToJsonAndSave***");
            using (StreamWriter sw = new StreamWriter(path2))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, lstOfEmployees);
            }
            string txt = File.ReadAllText(path2);
            Console.WriteLine(txt);
            Console.WriteLine("\n=====================================================\n");
        }

        internal void ConvertJsonToListOfObjects()
        {
            string text = File.ReadAllText(path2);
            List<Employee> lstOfEmpObj = JsonConvert.DeserializeObject<List<Employee>>(text);
            Console.WriteLine("***ConvertJsonToListOfObjects***");
            foreach (var objEmp in lstOfEmpObj)
            {
                Console.WriteLine(objEmp.FirstName);
                Console.WriteLine(objEmp.LastName);
                Console.WriteLine(objEmp.MobileNo);
                Console.WriteLine(objEmp.Email);
                Console.WriteLine(objEmp.Designation);
                Console.WriteLine(objEmp.Department);
            }
            Console.WriteLine("\n=====================================================\n");
        }

    }
}
