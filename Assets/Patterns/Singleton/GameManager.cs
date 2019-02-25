using UnityEngine;

public class GameManager : Singleton<GameManager> // Inheriting Singleton and specifying the type.
{
    public void InitializeGame()
    {
        Debug.Log("Initializing the game.");
    }
}