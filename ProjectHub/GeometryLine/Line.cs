namespace GeometryLine;


internal class Line
{
    // Declared length variable that stores the length of the line
    private double length;

    // Declared 2 Point objects for the end points of a line
    private Point point1;
    private Point point2;

    // Structure to describe a geometry point
    struct Point
    {
        // (x, y) Coordinates of a point
        public int x;
        public int y;

        // Sets the values for the point
        public void Set(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Displays the info on the point
        public void Describe()
        {
            Console.WriteLine("x: " + x + ", y: " + y);
        }
    }


    // Default constructor
    public Line()
    {
        point1.Set(0, 0);
        point2.Set(0, 0);
        length = 0;
    }

    // This constructor is invoked when parameters are passed
    public Line(int x1, int y1, int x2, int y2)
    {
        SetPoints(x1, y1, x2, y2);
    }

    // Initialise the list of lines
    public static void InitializeLines(List<Line> lines, int noOfLines)
    {
        for (int i = 0; i < noOfLines; i++)
            lines.Add(new Line());
    }
    // Calculate length of line from the points
    private void CalculateLength()
    {
        int xDifference = point1.x - point2.x;
        int yDifference = point1.y - point2.y;
        length = Math.Sqrt(Math.Pow(xDifference, 2) + Math.Pow(yDifference, 2));
    }

    // Displays the info of the line
    public void Describe()
    {
        Console.WriteLine("Point 1: ");
        point1.Describe();
        Console.WriteLine("Point 2: ");
        point2.Describe();
        Console.WriteLine("Length: " + length + "\n");
    }

    // Overloaded method; Displays the info of all lines
    public static void Describe(List<Line> lines)
    {
        int index = 1;
        foreach (Line line in lines)
        {
            Console.WriteLine("\nLine " + (index++) + " details:");
            line.Describe();
        }
    }

    // Sets the values for the 2 points and finds the length
    public void SetPoints(int x1, int y1, int x2, int y2)
    {
        point1.Set(x1, y1);
        point2.Set(x2, y2);
        CalculateLength();
    }

    // Get points from user
    public void GetPointsFromUser()
    {
        int x1, y1, x2, y2;
        Console.WriteLine("Enter Values for point 1: ");
        Console.Write("x: ");
        x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y: ");
        y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Values for point 2: ");
        Console.Write("x: ");
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y: ");
        y2 = Convert.ToInt32(Console.ReadLine());
        SetPoints(x1, y1, x2, y2);
    }

    // Overloaded method; Gets from user for lines in list
    public static void GetPointsFromUser(List<Line> lines)
    {
        int index = 1;
        foreach (Line line in lines)
        {
            Console.WriteLine("Enter Line " + (index++) + " details:");
            line.GetPointsFromUser();
        }
    }

    // Compares 2 lines and return 0 if equal, 1 if lesser, 2 if greater than line
    public int Compare(Line line)
    {
        if (this.length == line.length)
            return 0;
        else if (this.length < line.length)
            return 1;
        else
            return 2;
    }

    // Finds longest line from the list
    public static void Longest(List<Line> lines)
    {
        double longest = 0;
        foreach (Line line in lines)
            if (longest < line.length)
                longest = line.length;
        Console.WriteLine("Length of longest line in the list: " + longest);
    }
}