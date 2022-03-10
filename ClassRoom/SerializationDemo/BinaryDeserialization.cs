using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationDemo;

class BinaryDeSerialization
{
    public void DeSerialization()
    {
        FileStream fileStream = new FileStream(@"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\SerializationDemo\Example.txt", FileMode.Open);
        BinaryFormatter formatter = new BinaryFormatter();
        Demo deserializationdemo = (Demo)formatter.Deserialize(fileStream);
        Console.WriteLine($"Application name {deserializationdemo.ApplicationName} ---ApplicationId    {deserializationdemo.ApplicationId}");
        Console.ReadKey();
    }
}
