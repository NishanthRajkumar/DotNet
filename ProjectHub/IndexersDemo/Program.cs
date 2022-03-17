using IndexersDemo;

Employee emp = new Employee(101, "Pranaya", "SSE", 10000, "Mumbai", "IT", "Male");


Console.WriteLine("EID = " + emp["ID"]);
Console.WriteLine("Name = " + emp["Name"]);
Console.WriteLine("Job = " + emp["Job"]);
Console.WriteLine("Salary = " + emp["Salary"]);
Console.WriteLine("Location = " + emp["Location"]);
Console.WriteLine("Department = " + emp["Department"]);
Console.WriteLine("Gender = " + emp["Gender"]);


emp["Name"] = "Kumar";
emp["Salary"] = 65000;
emp["Location"] = "BBSR";


Console.WriteLine("=======Afrer Modification=========");
Console.WriteLine("EID = " + emp["ID"]);
Console.WriteLine("Name = " + emp["Name"]);
Console.WriteLine("Job = " + emp["Job"]);
Console.WriteLine("Salary = " + emp["Salary"]);
Console.WriteLine("Location = " + emp["Location"]);
Console.WriteLine("Department = " + emp["Department"]);
Console.WriteLine("Gender = " + emp["Gender"]);

