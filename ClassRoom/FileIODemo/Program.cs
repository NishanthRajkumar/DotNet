using FileIODemo;

Console.WriteLine("Checking if file exists");
FileIOMain.FileExists();
Console.WriteLine("\nReading all lines");
FileIOMain.ReadAllLines();
Console.WriteLine("\nReading all the text in file");
FileIOMain.ReadAllText();
Console.WriteLine("\nCopying file");
FileIOMain.FileCopy();
Console.WriteLine("\nDelete Example1.txt file");
FileIOMain.DeleteFile();
Console.WriteLine("\nRead using StreamReader");
FileIOMain.ReadFromStreamReader();
Console.WriteLine("\nWriting ti file using stream");
FileIOMain.WriteUsingStreamWriter();
Console.ReadKey();

Console.WriteLine("Testing WriteAllText:");
FileIOMain.NormalWrite();
Console.ReadKey();
Console.WriteLine("Testing Append:");
FileIOMain.AppendText();