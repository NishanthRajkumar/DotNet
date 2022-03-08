using LambdaExpressionDemo;

Console.Title = "Lamda Expression Demo";
Console.WriteLine("==========Lamda Expression Demo=========");

List<Person> listPersonInCity = new List<Person>();
ProjectMain.AddRecords(listPersonInCity);
// Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listPersonInCity);
//CheckingForTeenagerPerson(listPersonInCity);
//AllPersonsAverageAge(listPersonInCity);
ProjectMain.CheckNameExistOrNot(listPersonInCity);
Console.ReadKey();