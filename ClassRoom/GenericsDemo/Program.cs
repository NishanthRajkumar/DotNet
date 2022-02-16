using GenericsDemo;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
int[] intArray = { 1, 2, 3, 4, 5 };
double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

/*GenericsClass.toPrint(intArray);
GenericsClass.toPrint(doubleArray);
GenericsClass.toPrint(charArray);*/

GenericsMethods.toPrint<int>(intArray);
GenericsMethods.toPrint<double>(doubleArray);
GenericsMethods.toPrint<char>(charArray);