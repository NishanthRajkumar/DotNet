using EmployeePayrollUsingThreads;

Console.WriteLine("Employee Payroll using Threads");
string[] words = Sample.CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");

#region ParallelTasks
Parallel.Invoke(() =>
{
    Console.WriteLine("Begin first task...");
    Sample.GetLongestWord(words);
},// close 1st action
() =>
{
    Console.WriteLine("Begin second task...");
    Sample.GetMostCommonWords(words);
},
() =>
{
    Console.WriteLine("Begin third task...");
    Sample.GetMostCommonWords(words);
}// close third action
);// close parallel.invoke
#endregion
//Console.ReadKey();
