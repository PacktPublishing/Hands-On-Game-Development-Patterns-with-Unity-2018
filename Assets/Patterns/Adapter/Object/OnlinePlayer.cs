using UnityEngine;

namespace Pattern.ObjectAdapter
{
    public sealed class OnlinePlayer : ScriptableObject
    {
        public string GetFirstName(int id)
        {
            // Lookup online database.
            return "John"; // Retun a placeholder name.
        }

        public string GetLastName(int id)
        {
            // Lookup online database.
            return "Doe"; // Return a placeholder last name.
        }

        public string GetFullName(int id)
        {
            // Lookup online database and pull the full name in this sequence [Last Name & First Name].
            return "Doe Jonn";
        }
    }
}
