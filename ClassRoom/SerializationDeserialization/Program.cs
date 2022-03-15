using System;

namespace SerializationDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryDemo binary = new BinaryDemo();
            binary.ConvertObjectToBinary(); // Serialization
            binary.ConvertBinaryToObject(); // Deserialization
            binary.ConvertListOfObjectToBnaryAndSave();
            binary.ConvertListOfBinaryDataToObject();

            JsonDemo json = new JsonDemo();
            json.ConvertObjectToJsonAndSave();
            json.ConvertJsonToObject();
            json.ConvertlstOfObjectToJsonAndSave();
            json.ConvertJsonToListOfObjects();

            XMLDemo xml = new XMLDemo();
            xml.AdddataIntoXML();
            xml.ReadDataFromXML();
            xml.AdddataIntoXMLList();
            xml.ReadDataFromXMLList();
        }
    }
}
