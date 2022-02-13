using ConceptTesting.ReadOnlyTests;
using ConceptTesting.StaticTests;

Console.Title = "Concept Testing App";

//StaticTest.ConstructorTesting();
//StaticTest.TestStaticClass();

// ReadOnly Testing
ReadOnlyTest test1 = new();
ReadOnlyTest test2 = new(5);
test1.Display();
test2.Display();

Console.ReadKey();