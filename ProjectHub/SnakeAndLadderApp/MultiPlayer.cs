using HubCommonLibrary;

namespace SnakeAndLadderApp;

// Multiplayer Initialization and setup
internal static class MultiPlayer
{
    // Initializes the player and starts the game
    public static void Start()
    {
        List<SnakeAndLadder> players = new();
        int totalPlayers = Input.GetPositiveInt("Enter no of players: ");
        for (int i = 0; i < totalPlayers; i++)
            players.Add(new SnakeAndLadder());
        if (players.Count > 0)
        {
            // Print all players positions
            SnakeAndLadder.Describe(players);

            // Start Game
            SnakeAndLadder.PlayTillEnd(players);
        }
    }
}