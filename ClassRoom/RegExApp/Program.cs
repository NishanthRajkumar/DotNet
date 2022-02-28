using RegExApp;

Console.Title = "RegeEx App";
Console.WriteLine("==========RegEx App==========");

Patterns patterns = new Patterns();

//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
if (patterns.validatePinCode("400 088"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");