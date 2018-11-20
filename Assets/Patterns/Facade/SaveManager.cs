/** 
using System;
using System.IO;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : Singleton
{
    public Player m_Player;
    public ScoreManager m_ScoreManager;
    public UIManager m_UIManager;
    public CloudManager m_CloudManager;

    private PlayerData m_PlayerData;

    public void SaveGame()
    {
        // Initializing a new Player Data 
        m_PlayerData = new PlayerData();

        m_PlayerData.health = m_Player.GetHealth();
        m_PlayerData.playerID = m_Player.GetPlayerID();
        m_PlayerData.score = m_ScoreManager.GetScore(m_Player.GetPlayerID())

        // Let's serialize the player data.
        // this.SerializePlayerData(m_PlayerData, true);

        // Show the save icon on the corner of the screen.
        // m_UIManager.DisplaySaveIcon();
    }

    private void SerializePlayerData(PlayerData playerData, bool isCloudSave)
    {
        // Serializing the PlayerData instance with the current data.
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        bf.Serialize(file, data);
        file.Close();

        // Uploading the serialized playerInfo.dat file to the cloud.
        if (isCloudSave)
        {
            m_CloudManager.UploadSaveGame(Application.persistentDataPath + "/playerInfo.dat");
        }
    }
}
**/