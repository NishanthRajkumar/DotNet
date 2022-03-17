using CsvHelper;
using Newtonsoft.Json;
using System.Globalization;

namespace CSVHelperAndJson;

internal class ReadCSV_And_WriteJSON
{
    private static string importFilePath = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\CSVHelperAndJson\Utility\Addresses.csv";
    private static string exportFilePath = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\CSVHelperAndJson\export.json";
    public static void ImplementCSVToJSON()
    {
        using (var reader = new StreamReader(importFilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<AddressData>().ToList();
            Console.WriteLine("Read data successfully from addresses csv.");
            foreach (AddressData addressData in records)
            {
                Console.Write("\t" + addressData.firstname);
                Console.Write("\t" + addressData.lastname);
                Console.Write("\t" + addressData.address);
                Console.Write("\t" + addressData.city);
                Console.Write("\t" + addressData.state);
                Console.Write("\t" + addressData.code);
                Console.WriteLine();
            }

            Console.WriteLine("**********************Reading from csv file and Write to csv file **************************");
            //Writing json file
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(exportFilePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, records);
            }
            Console.WriteLine("Succesfully read from csv and wrote to json");
        }
    }
}