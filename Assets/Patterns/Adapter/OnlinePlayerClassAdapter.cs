using UnityEngine;

public class OnlinePlayerClassAdapter : OnlinePlayer, iOnlinePlayer
{
    public string GetName(int userId)
    {
        return this.GetFullName(userId);
    }
}
