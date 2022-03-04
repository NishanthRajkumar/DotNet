using ReflectionDemo;


Console.WriteLine("Welcome to reflection Demo");
CustomerInfo obj = new CustomerInfo();
ReflectionOnCustomer.ReflectionTest();
obj.Id = -2;
Console.WriteLine(obj.Id);
Console.ReadKey();