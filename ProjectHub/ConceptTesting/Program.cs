using ConceptTesting.ReadOnlyTests;

Console.Title = "Concept Testing App";

//StaticTest.ConstructorTesting();
//StaticTest.TestStaticClass();

// ReadOnly Testing
ReadOnlyTest test1 = new();
ReadOnlyTest test2 = new(5);
Console.WriteLine("test1");
test1.Display();
Console.WriteLine("test2");
test2.Display();

Console.ReadKey();