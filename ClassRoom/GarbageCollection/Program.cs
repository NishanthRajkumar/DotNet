/*//Objcet obj = null;
long mem1 = GC.GetTotalMemory(false);//2 lakh
                                     //GC.SuppressFinalize(null);
{
    int[] values = new int[50000];//2 lakh bytes
    values = null;
}
long mem2 = GC.GetTotalMemory(false);
{
    //Collect Garbage
    GC.Collect();
}

long mem3 = GC.GetTotalMemory(false);
Console.WriteLine("hello");
{
    Console.WriteLine(mem1);
    Console.WriteLine(mem2);
    Console.WriteLine(mem3);
}


Console.WriteLine("#######################");
long bytes1 = GC.GetTotalMemory(false);// Get memory in bytes
byte[] memory = new byte[1000 * 1000 * 10]; //Ten million bytes
memory[0] = 1;
//memory = null;
long bytes2 = GC.GetTotalMemory(false);
long bytes3 = GC.GetTotalMemory(true);
Console.WriteLine(bytes1);
Console.WriteLine(bytes2);
Console.WriteLine(bytes2 - bytes1);
Console.WriteLine(bytes3);
Console.WriteLine(bytes3 - bytes2);
Console.ReadKey();
*/


GC.Collect();