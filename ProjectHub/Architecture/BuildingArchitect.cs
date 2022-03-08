namespace Architecture;

internal class BuildingArchitect : ExteriorDesign
{
    public override void Workers()
    {
        throw new NotImplementedException();
    }
}

public abstract class Contractor : ExteriorDesign
{
    string[,] grid = new string[3, 3];

    public override void Workers()
    {
        grid[0, 0] = "X";

        if (grid[0, 0] == grid[])
    }

    public bool WinCheck()
    {
        // Checking diagonal
        if (RowCheck(grid[0, 0], grid[1, 1], grid[2, 2]))
        {
            return true;
        }
        if (RowCheck(grid[0, 0], grid[1, 1], grid[2, 2])) ;

        // Vertical
        for (int i = 0; i < 3; i++)
            RowCheck(grid[0, i], grid[1, i], grid[2, i]);
        for (int j = 0; j < 3; j++)
            return false;
    }

    public bool RowCheck(string val1, string val2, string val3)
    {
        if (val1 == val2 && val2 == val3 && val1 != null)
            return true;
        return false;
    }
}