using Pattern.ClassAdapter;

public class OnlinePlayerClassAdapter : OnlinePlayer, iOnlinePlayer
{
    public string GetFullNameLastFirst(int userId)
    {
        return GetFullName(userId);
    }

    public string GetFullNameFirstLast(int userId)
    {
        return GetFirstName(userId) + " " + GetLastName(userId);
    }
}
