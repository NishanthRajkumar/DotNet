using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationDeserialization
{
    class BinaryDemo
    {
        string path1 = Directory.GetCurrentDirectory() + @"\BinaryFile1.txt";
        string path2 = Directory.GetCurrentDirectory() + @"\BinaryFile2.txt";
        // Serialization converting object to binary
        // Deserialization converting binary to object

        internal void ConvertObjectToBinary()
        {
            Employee emp = GlobalClass.CreateEmployeeObject();

            FileStream fileStream = new FileStream(path1, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, emp); // convert object to binary & writes in a text file  
            fileStream.Close();
            fileStream.Dispose();

            Console.WriteLine("*** ConvertObjectToBinary ***");
            string binaryTxt = File.ReadAllText(path1);
            Console.WriteLine(binaryTxt);
            Console.WriteLine("\n=====================================================\n");
        }

        internal void ConvertBinaryToObject()
        {
            FileStream fileStream = new FileStream(path1, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            Employee deserializedEmpData = (Employee)formatter.Deserialize(fileStream);

            Console.WriteLine("*** ConvertBinaryToObject ***");
            Console.WriteLine(deserializedEmpData.FirstName);
            Console.WriteLine(deserializedEmpData.LastName);
            Console.WriteLine(deserializedEmpData.MobileNo);
            Console.WriteLine(deserializedEmpData.Email);
            Console.WriteLine(deserializedEmpData.Designation);
            Console.WriteLine(deserializedEmpData.Department);
            Console.WriteLine("\n=====================================================\n");
        }

        internal void ConvertListOfObjectToBnaryAndSave()
        {
            Employee employee = GlobalClass.CreateEmployeeObject();
            Employee employee2 = new Employee();
            employee2.FirstName = "Ravi";
            employee2.LastName = "Sonkar";
            employee2.MobileNo = 1234567890;
            employee2.Email = "ravi@gmail.com";
            employee2.Designation = "Software Developer";
            employee2.Department = "IT";

            List<Employee> lstOfEmployees = new List<Employee>();
            lstOfEmployees.Add(employee);
            lstOfEmployees.Add(employee2);

            FileStream fileStream = new FileStream(path2, FileMode.Create); // creating a file
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, lstOfEmployees); // convert object to binary & writes in a text file
            fileStream.Close();
            fileStream.Dispose();

            Console.WriteLine("***ConvertListOfObjectToBnaryAndSave***");
            string binaryData = File.ReadAllText(path2);
            Console.WriteLine(binaryData);
            Console.WriteLine("\n=====================================================\n");
        }

        internal void ConvertListOfBinaryDataToObject()
        {
            FileStream fileStream = new FileStream(path2, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            List<Employee> deserializedeEmployees = (List<Employee>)formatter.Deserialize(fileStream);
            Console.WriteLine("***ConvertListOfBinaryDataToObject***");
            foreach (var emp in deserializedeEmployees)
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.LastName);
                Console.WriteLine(emp.MobileNo);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Designation);
                Console.WriteLine(emp.Department);
            }
            Console.WriteLine("\n=====================================================\n");
        }
    }
}
