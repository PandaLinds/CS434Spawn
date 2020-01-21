using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public iCopyable mCopy;

    public Enemy SpawnEnemy(Enemy prototype)
    {
        mCopy = prototype.Copy();
        return (Enemy)mCopy;
    }
}
