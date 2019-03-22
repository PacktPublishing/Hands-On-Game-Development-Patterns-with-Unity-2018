using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : Singleton<ObjectPool>
{
        // The objects to pool.
        public GameObject[] objects;

        // The list of pooled objects.
        public List<GameObject>[] pooledObjects;

        // The amount of objects to buffer.
        public int[] amountToBuffer;

        public int defaultBufferAmount = 3;

        // The container of pooled objects.
        protected GameObject containerObject;

        void Start()
        {
            containerObject = new GameObject("ObjectPool");
            pooledObjects = new List<GameObject>[objects.Length];

            int i = 0;
            foreach (GameObject obj in objects)
            {
                pooledObjects[i] = new List<GameObject>();

                int bufferAmount;

                if (i < amountToBuffer.Length)
                {
                    bufferAmount = amountToBuffer[i];
                }
                else
                {
                    bufferAmount = defaultBufferAmount;
                }

                for (int n = 0; n < bufferAmount; n++)
                {
                    GameObject newObj = Instantiate(obj) as GameObject;
                    newObj.name = obj.name;
                    PoolObject(newObj);
                }

                i++;
            }
        }

        // Pull an object of a specific type from the pool.
        public GameObject PullObject(string objectType)
        {
            bool onlyPooled = false;
            for (int i = 0; i < objects.Length; i++)
            {
                GameObject prefab = objects[i];

                if (prefab.name == objectType)
                {
                    if (pooledObjects[i].Count > 0)
                    {
                        GameObject pooledObject = pooledObjects[i][0];
                        pooledObject.SetActive(true);
                        pooledObject.transform.parent = null;

                        pooledObjects[i].Remove(pooledObject);

                        return pooledObject;

                    }
                    else if (!onlyPooled)
                    {
                        return Instantiate(objects[i]) as GameObject;
                    }

                    break;
                }
            }

            // Null if there's a hit miss.
            return null;
        }

        // Add object of a specific type to the pool.
        public void PoolObject(GameObject obj)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i].name == obj.name)
                {
                    obj.SetActive(false);
                    obj.transform.parent = containerObject.transform;
                    pooledObjects[i].Add(obj);
                    return;
                }
            }

            Destroy(obj);
        }
    }