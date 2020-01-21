using UnityEngine;

public class Client : MonoBehaviour
{
    public Drone mDrone;
    public Sniper mSniper;
    public EnemySpawner mSpawner;

    private Enemy mSpawn;
    private int mIncrementorDrone = 0;
    private int mIncrementorSniper = 0;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            mSpawn = mSpawner.SpawnEnemy(mDrone);

            mSpawn.name = "DroneClone_" + ++mIncrementorDrone;
            mSpawn.transform.Translate(Vector3.forward * mIncrementorDrone * 1.5f);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            mSpawn = mSpawner.SpawnEnemy(mSniper);

            mSpawn.name = "SniperClone_" + ++mIncrementorSniper;
            mSpawn.transform.Translate(Vector3.forward * mIncrementorSniper * 1.5f);
        }
    }
}
