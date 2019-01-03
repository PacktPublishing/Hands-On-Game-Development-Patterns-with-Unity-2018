using UnityEngine;

namespace Pattern.ClassAdapter
{
    public class Client : MonoBehaviour
    {
        private iOnlinePlayer m_OnlinePlayer;

        void Update()
        {
            // Press U to get the user info.
            if (Input.GetKeyDown(KeyCode.U))
            {
                m_OnlinePlayer = OnlinePlayerClassAdapter.CreateInstance<OnlinePlayerClassAdapter>(); // Inits the adapted version of the User class.

                string FirstName = m_OnlinePlayer.GetFirstName(79);
                string LastName = m_OnlinePlayer.GetLastName(79);

                string FullName = m_OnlinePlayer.GetName(79);

                Debug.Log(FirstName);
                Debug.Log(LastName);
                Debug.Log(FullName);
            }
        }
    }
}