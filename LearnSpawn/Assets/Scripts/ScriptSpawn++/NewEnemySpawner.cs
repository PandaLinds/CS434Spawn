using UnityEngine;

public class NewEnemySpawner : MonoBehaviour
{
    public EnemyFactory mFactory;

    public void SpawnEnemies(EnemyType EnemyToSpawn)
    {
        //HAVE FACTORY MANUFACTURE THEM!!!

        Enemies mEnemy = mFactory.GetEnemy(EnemyToSpawn);

        mEnemy.Fight();
    }
}