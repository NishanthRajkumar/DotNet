using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SerializationDeserialization
{
    class XMLDemo
    {
        string path1 = Directory.GetCurrentDirectory() + "/File1.xml";
        string path2 = Directory.GetCurrentDirectory() + "/File2.xml";

        public void AdddataIntoXML()
        {
            Console.WriteLine("***AdddataIntoXML***");
            Employee emp = GlobalClass.CreateEmployeeObject();
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter(path1))
            {
                serializer.Serialize(writer, emp);
            }
            string txt = File.ReadAllText(path1);
            Console.WriteLine(txt);
            Console.WriteLine("\n=====================================================\n");
        }

        public void ReadDataFromXML()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Employee));
            TextReader reader = new StreamReader(path1);
            Employee XmlData = (Employee)deserializer.Deserialize(reader);

            reader.Close();
            Console.WriteLine("***ReadDataFromXML***");
            Console.WriteLine(XmlData.FirstName);
            Console.WriteLine(XmlData.LastName);
            Console.WriteLine(XmlData.MobileNo);
            Console.WriteLine(XmlData.Email);
            Console.WriteLine(XmlData.Designation);
            Console.WriteLine(XmlData.Department);
            Console.WriteLine("\n=====================================================\n");
        }

        public void AdddataIntoXMLList()
        {
            Console.WriteLine("***AdddataIntoXML***");
            Employee employee = GlobalClass.CreateEmployeeObject();
            Employee employee2 = new Employee();
            employee2.FirstName = "Ravi";
            employee2.LastName = "Sonkar";
            employee2.MobileNo = 1234567890;
            employee2.Email = "ravi@gmail.com";
            employee2.Designation = "Software Developer";
            employee2.Department = "IT";
            List<Employee> lstEmployees = new List<Employee>();
            lstEmployees.Add(employee);
            lstEmployees.Add(employee2);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            using (TextWriter writer = new StreamWriter(path2))
            {
                serializer.Serialize(writer, lstEmployees);
            }
            string txt = File.ReadAllText(path2);
            Console.WriteLine(txt);
            Console.WriteLine("\n=====================================================\n");

        }

        public void ReadDataFromXMLList()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Employee>));
            TextReader reader = new StreamReader(path2);
            object obj = deserializer.Deserialize(reader);
            List<Employee> XmlDataList = (List<Employee>)obj;
            reader.Close();
            Console.WriteLine("***ReadDataFromXMLList***");
            foreach (var XmlData in XmlDataList)
            {
                Console.WriteLine(XmlData.FirstName);
                Console.WriteLine(XmlData.LastName);
                Console.WriteLine(XmlData.MobileNo);
                Console.WriteLine(XmlData.Email);
                Console.WriteLine(XmlData.Designation);
                Console.WriteLine(XmlData.Department);
            }
            Console.WriteLine("\n=====================================================\n");
        }
    }
}
