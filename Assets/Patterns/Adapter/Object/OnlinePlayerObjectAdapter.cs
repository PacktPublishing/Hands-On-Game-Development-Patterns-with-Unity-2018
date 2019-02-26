using UnityEngine;
using Pattern.ObjectAdapter;

public class OnlinePlayerObjectAdapter : ScriptableObject
{
    public string GetFullName(OnlinePlayer onlinePlayer, int userId)
    {
        return onlinePlayer.GetFirstName(userId) + " " + onlinePlayer.GetLastName(userId);
    }
}