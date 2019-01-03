using UnityEngine;

namespace Pattern.ObjectPool_
{
    public class Client : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                GameObject walker = ObjectPool.Instance.PullObject("Walker");
                walker.transform.Translate(Vector3.forward * Random.Range(-5.0f, 5.0f));
                walker.transform.Translate(Vector3.right * Random.Range(-5.0f, 5.0f));
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                object[] objs = GameObject.FindObjectsOfType(typeof(GameObject));

                foreach (object o in objs)
                {
                    GameObject obj = (GameObject)o;

                    if (obj.gameObject.GetComponent<Zombie.Walker>() != null)
                    {
                        ObjectPool.Instance.PoolObject(obj);
                    }
                }
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 300, 30), "Press G to pull a Walker from the pool.");
            GUI.Label(new Rect(10, 30, 300, 30), "Press P to send the Walkers back into the pool.");
        }
    }
}