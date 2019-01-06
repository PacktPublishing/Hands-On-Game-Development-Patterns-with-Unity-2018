using UnityEngine;

public class GameManager : Singleton<GameManager> // Inheriting Singleton and specifying the type.
{
    public void InitializeGame()
    {
        // Load persistent game state variables from the save system.
        // Load game systems and dependencies.
        Debug.Log("Initializing the game.");
    }
}