using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public iCopyable m_Copy; // Because of polymorphism, we don't need to know the exact type of the object we just spawned, only know it's a copyable entity.

    public Enemy SpawnEnemy(Enemy prototype) // Our spawn system only spawns enemies by copying a given prototype object.
    {
        m_Copy = prototype.Copy(); // We don't know and don't care how the prototype is copied, we just need it to do it.
        return (Enemy)m_Copy;
    }
}
