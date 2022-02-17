using GenericsDemo;

Console.WriteLine("Hello, World!");
int[] intArray = { 1, 2, 3, 4, 5 };
double[] doubleArray = { 1.1, 2.2, 6.6, 3.3, 4.4 };
char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

/*GenericsClass.ToPrint(intArray);
GenericsClass.ToPrint(doubleArray);
GenericsClass.ToPrint(charArray);*/

GenericsMethods.ToPrint<int>(intArray);
GenericsMethods.ToPrint<double>(doubleArray);
GenericsMethods.ToPrint<char>(charArray);

GenericClassMaximum<int> intGeneric = new(intArray);
GenericClassMaximum<double> doubleGeneric = new(doubleArray);
intGeneric.PrintMaxValue();
doubleGeneric.PrintMaxValue();