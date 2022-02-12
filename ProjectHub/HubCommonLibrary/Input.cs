namespace HubCommonLibrary
{
    public class Input
    {
        public static int GetPositiveInt(string message)
        {
            int n;
            bool IS_INT32;
            do
            {
                do
                {
                    Console.Write(message);
                    IS_INT32 = Int32.TryParse(Console.ReadLine(), out n);
                } while (IS_INT32 is false);
            } while (n < 0);
            return n;
        }
    }
}