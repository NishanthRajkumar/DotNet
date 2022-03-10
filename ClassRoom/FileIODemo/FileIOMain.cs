namespace FileIODemo;

internal class FileIOMain
{
    public static void FileExists()
    {
        String path = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\FileIODemo\Example.txt";
        if (File.Exists(path))
            Console.WriteLine("File exists");
        else
            Console.WriteLine("File doesn't exists");
    }

    public static void ReadAllLines()
    {
        String path = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\FileIODemo\Example.txt";
        var lines = File.ReadAllLines(path);
        Console.WriteLine(lines[0]);
        Console.WriteLine(lines[1]);

    }

    public static void ReadAllText()
    {
        String path = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\FileIODemo\Example.txt";
        String lines;
        lines = File.ReadAllText(path);
        Console.WriteLine(lines);

    }

    public static void FileCopy()
    {
        String path = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\FileIODemo\Example.txt";
        String copypath = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\FileIODemo\Example1.txt";

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
        }
    }

    public static void WriteUsingStreamWriter()
    {
        String path = @"C:\Users\Nishanth\Desktop\codingclub\RFP\DotNet\ClassRoom\FileIODemo\Example.txt";

        using (StreamWriter sr = File.AppendText(path))
        {
            sr.WriteLine("Hellow World - .Net is awesome1");
            sr.Close();
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
