using ExceptionHandling;

Console.Title = "Exception Handling testing App";
Console.WriteLine("==========Exception Handling==========");

Thread t1 = new Thread(() => Test.ConvertStringToInt(""));
Thread t2 = new Thread(() => Test.TryConvertStringToInt(""));

//t1.Start();
t2.Start();

//while (t1.IsAlive) ;
while (t2.IsAlive) ;

//Test.TryConvertStringToInt("sdfsf");

Console.WriteLine("Thread completed and continuing in Main");

Console.ReadKey();