using UnityEngine;

namespace Pattern.ObjectAdapter
{
    public class Client : MonoBehaviour
    {
        private OnlinePlayer m_OnlinePlayer;
        private OnlinePlayerObjectAdapter m_OnlinePlayerAdapter;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                m_OnlinePlayer = ScriptableObject.CreateInstance<OnlinePlayer>();
                m_OnlinePlayerAdapter = ScriptableObject.CreateInstance<OnlinePlayerObjectAdapter>();

                string FirstName = m_OnlinePlayer.GetFirstName(79);
                string LastName = m_OnlinePlayer.GetLastName(79);

                string FullNameLastFirst = m_OnlinePlayer.GetFullName(79);
                string FullNameFirstLast = m_OnlinePlayerAdapter.GetFullName(m_OnlinePlayer, 79);

                Debug.Log(FirstName);
                Debug.Log(LastName);
                Debug.Log(FullNameLastFirst);
                Debug.Log(FullNameFirstLast);
            }
        }
    }
}
