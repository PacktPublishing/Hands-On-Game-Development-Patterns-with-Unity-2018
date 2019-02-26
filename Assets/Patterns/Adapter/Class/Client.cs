using UnityEngine;

namespace Pattern.ClassAdapter
{
    public class Client : MonoBehaviour
    {
        private iOnlinePlayer m_OnlinePlayer;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                m_OnlinePlayer = ScriptableObject.CreateInstance<OnlinePlayerClassAdapter>();

                string FirstName = m_OnlinePlayer.GetFirstName(79);
                string LastName = m_OnlinePlayer.GetLastName(79);

                string FullNameLastFirst = m_OnlinePlayer.GetFullNameLastFirst(79);
                string FullNameFirstLast= m_OnlinePlayer.GetFullNameFirstLast(79);

                Debug.Log(FirstName);
                Debug.Log(LastName);
                Debug.Log(FullNameLastFirst);
                Debug.Log(FullNameFirstLast);
            }
        }
    }
}