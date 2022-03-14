namespace FileIODemo;

public class FileIOMain
{
    static String path = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\FileIODemo\Example.txt";
    static String copypath = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\FileIODemo\Example1.txt";


    public static void FileExists()
    {

        if (File.Exists(path))
            Console.WriteLine("File exists");
        else
            Console.WriteLine("File doesn't exists");
    }

    public static void ReadAllLines()
    {
        var lines = File.ReadAllLines(path);
        Console.WriteLine(lines[0]);
        Console.WriteLine(lines[1]);
        Console.WriteLine(lines[4]);
    }

    public static void ReadAllText()
    {
        String lines;
        lines = File.ReadAllText(path);
        Console.WriteLine(lines);

    }

    public static void FileCopy()
    {
        File.Copy(path, copypath, true);
    }

    public static void DeleteFile()
    {
        String path = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\FileIODemo\Example1.txt";
        File.Delete(path);
    }

    public static void ReadFromStreamReader()
    {
        String path = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\FileIODemo\Example.txt";
        using (StreamReader sr = File.OpenText(path))
        {
            String s = String.Empty;
            while ((s = sr.ReadLine()) != null)
                Console.WriteLine(s);
            //sr.Close();
        }
    }

    public static void WriteUsingStreamWriter()
    {
        String path = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\FileIODemo\Example.txt";

        using (StreamWriter sr = File.AppendText(path))
        {
            sr.WriteLine(@"\nSampada and Nishanth are testing Indal sir's code\n The end of app");
            sr.Close();
            Console.WriteLine(File.ReadAllText(path));
        }
    }

    public static void NormalWrite()
    {
        File.WriteAllText(path, "I want to add my new text line to Example.txt file");
    }

    public static void AppendText()
    {
        File.AppendAllText(path, "\nI want to Append my new text line to Example.txt file");
    }
}
