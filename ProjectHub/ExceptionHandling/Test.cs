namespace ExceptionHandling;

internal static class Test
{
    public static void ConvertStringToInt(string txt)
    {
        Thread.Sleep(3000);
        int num = Convert.ToInt32(txt);
    }

    public static void TryConvertStringToInt(string txt)
    {
        Thread.Sleep(3000);
        try
        {
            int num = Convert.ToInt32(txt);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
