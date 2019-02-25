using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : Singleton<SaveManager>
{
    private UIManager m_UIManager;
    private PlayerData m_PlayerData;
    private ScoreManager m_ScoreManager;
    private CloudManager m_CloudManager;

    public void SaveGame(Player player)
    {
        // 1 - Show the save icon on the corner of the screen.
        m_UIManager = new UIManager();
        m_UIManager.DisplaySaveIcon();

        // 2 - Initializing a new Player Data.
        m_PlayerData = new PlayerData();
        m_PlayerData.health = player.GetHealth();
        m_PlayerData.playerID = player.GetPlayerID();

        // 3 - Getting the player's high score.
        m_ScoreManager = new ScoreManager();
        m_PlayerData.score = m_ScoreManager.GetScore(player.GetPlayerID());
        
        // 4 - Let's serialize the player data.
        SerializePlayerData(m_PlayerData, true);
    }
    
    private void SerializePlayerData(PlayerData playerData, bool isCloudSave)
    {
        // Serializing the PlayerData instance with the current data.
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        bf.Serialize(file, playerData);
        file.Close();
        
        // Uploading the serialized playerInfo.dat file to the cloud.
        if (isCloudSave)
        {
            m_CloudManager = new CloudManager();
            m_CloudManager.UploadSaveGame(Application.persistentDataPath + "/playerInfo.dat");
        }
    }
}