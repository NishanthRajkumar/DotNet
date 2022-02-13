using HubCommonLibrary;


namespace GeometryLine;

// Provides different styles of line comparison models
internal static class ComparisonModel
{
    // Two line comparison model
    public static void TwoLines()
    {
        // Create 2 Line objects
        Line line1 = new();
        Line Line2 = new();

        // Input the points for each line
        Console.WriteLine("Enter line 1 details: ");
        line1.GetPointsFromUser();
        Console.WriteLine("Enter line 2 details: ");
        Line2.GetPointsFromUser();

        // Display the info of each line
        Console.WriteLine("\nLine 1: ");
        line1.Describe();
        Console.WriteLine("Line 2: ");
        Line2.Describe();

        // Compare the line lengths and display result
        int result = line1.Compare(Line2);
        switch (result)
        {
            case 0:
                Console.WriteLine("The lines are equal in length");
                break;
            case 1:
                Console.WriteLine("Line 1 length is lesser than line 2");
                break;
            case 2:
                Console.WriteLine("Line 1 length is greater than line 2");
                break;
            default:
                Console.WriteLine("Error!!");
                break;
        }
    }

    //Multi line comparison model
    public static void MultiLine()
    {
        List<Line> lines = new List<Line>();
        int noOfLines = Input.GetPositiveInt("Enter no of lines to Initialize: ");
        Line.InitializeLines(lines, noOfLines);
        Line.GetPointsFromUser(lines);
        Line.Describe(lines);
        Line.Longest(lines);
    }
}