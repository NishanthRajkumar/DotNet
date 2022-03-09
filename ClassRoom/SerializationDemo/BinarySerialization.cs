using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationDemo;

class BinarySerialization
{
    public void Serialization()
    {
        Demo sample = new Demo();
        FileStream fileStream = new FileStream(@"D:\Fellowship\Fellowship05-Day20_FileIO\SerializationDemo\Example.txt", FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fileStream, sample);
        Console.ReadKey();
    }
}

[Serializable]
public class Demo
{
    public string ApplicationName { get; set; } = "Binary Serialize";
    public int ApplicationId { get; set; } = 1001;
}

