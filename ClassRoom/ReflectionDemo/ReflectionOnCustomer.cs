using System.Reflection;

namespace ReflectionDemo;

internal class ReflectionOnCustomer
{
    public static void ReflectionTest()
    {
        Type type = Type.GetType("ReflectionDemo.CustomerInfo");
        Console.WriteLine("Full Name :{0}", type.FullName);
        Console.WriteLine("Class name is : {0}", type.Name);
        Console.WriteLine("Methods in customerInfo class");
        MethodInfo[] methods = type.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.ReturnType.Name + " " + method.Name);
        }
        Console.WriteLine("Properties in CustomerInfo class");
        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine(property.PropertyType.Name + " " + property.Name);
        }

        Console.WriteLine("Constructors in CustomerInfo class");
        ConstructorInfo[] constructors = type.GetConstructors();
        foreach (ConstructorInfo constructor in constructors)
        {
            Console.WriteLine(constructor.ToString());
        }
    }
}