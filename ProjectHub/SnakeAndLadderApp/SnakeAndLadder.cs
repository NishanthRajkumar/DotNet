namespace SnakeAndLadderApp;

internal class SnakeAndLadder
{
    // Game related attributes declared here
    private int position;
    private bool winCheck;
    private int totalDieRoll;

    // Common Random object for the class
    static readonly Random random = new();

    // Default Constructor
    public SnakeAndLadder()
    {
        position = 0;
        winCheck = false;
        totalDieRoll = 0;
    }

    // Resets the values of the class attributes
    public void Reset()
    {
        position = 0;
        winCheck = false;
        totalDieRoll = 0;
    }

    // Describes the player's position in the game
    public void Describe()
    {
        Console.WriteLine("Position: " + position);
    }

    // Describe all players' position in the list
    public static void Describe(List<SnakeAndLadder> players)
    {
        int count = 0;
        foreach (SnakeAndLadder player in players)
            Console.WriteLine("Player " + ++count + " position: " + player.position);
    }

    // Rolls die using Random
    private void RollDie()
    {
        totalDieRoll++;
        int chkContinue = 0;
        int roll = random.Next(1, 7);
        Console.WriteLine("\nRolled: " + roll);
        if (winCheck is false)
            chkContinue = MovePlayer(roll);
        if (winCheck is false && chkContinue == 1)
            Option(roll);
    }

    // Checks option for player using Random
    private void Option(int roll)
    {
        int option = random.Next(0, 3);
        switch (option)
        {
            case 0:
                Console.WriteLine("No Play");
                break;
            case 1:
                Ladder(roll);
                break;
            case 2:
                Snake(roll);
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }
    }

    // Actions to take when option is snake
    private void Snake(int roll)
    {
        Console.WriteLine("Oops! Snake Trap!!!");
        Console.WriteLine("Going down by " + roll);
        MovePlayer(-roll);
    }

    // Actions to take when option is ladder
    private void Ladder(int roll)
    {
        Console.WriteLine("Yay! A Ladder!!!");
        Console.WriteLine("Going up by " + roll);
        MovePlayer(roll);
        Console.WriteLine("You get another turn to roll Since you got ladder");
        RollDie();
    }

    // Checks if position is out of bounds in the game
    // Returns 1 for player to conitinue to option if not out of bounds
    // Returns 0 for player to not conitinue to option if out of bounds
    private int CheckBoundary(int displacement)
    {
        if (position < 0)
        {
            position = 0;
            return 0;
        }
        else if (position > 100)
        {
            position -= displacement;
            Console.WriteLine("Oops! You shot past position 100");
            Console.WriteLine("You are moved back to previous position");
            return 0;
        }
        else
            return 1;
    }

    // Move player acroos the board
    // Returns 1 for player to conitinue to option
    // Returns 0 for player to not conitinue to option
    private int MovePlayer(int displacement)
    {
        position += displacement;
        if (position == 100)
        {
            winCheck = true;
            return 0;
        }
        return CheckBoundary(displacement);
    }

    // Play till end with n players
    public static void PlayTillEnd(List<SnakeAndLadder> players)
    {
        // Loop run until one of the players win
        while (MultiPlayersWinCheck(players) is false)
        {
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("\nPlayer " + (i + 1) + " turn: ");
                players[i].RollDie();
                players[i].Describe();
            }
        }

        // Traverses the list until reaches the player who won
        for (int i = 0; i < players.Count; i++)
            if (players[i].winCheck is true)
            {
                Console.WriteLine("\nCongratulations Player " + (i + 1) + "!! You Won!!");
                break;
            }

        // Prints the Total Die rolls of all players
        for (int i = 0; i < players.Count; i++)
            Console.WriteLine("Player " + (i + 1) + " Total die rolls: " + players[i].totalDieRoll);
    }

    private static bool MultiPlayersWinCheck(List<SnakeAndLadder> players)
    {
        foreach (SnakeAndLadder player in players)
            if (player.winCheck is true)
                return true;
        return false;
    }
}