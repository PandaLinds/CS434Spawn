using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboClient : MonoBehaviour
{
    //Combining the instansiations

    public NPCSpawner newSpawnerNPC;
    public Sniper mSniper;
    public EnemySpawner mSpawner;

    private Enemy mSpawn;
    private int mIncrementorDrone = 0;
    private int mIncrementorSniper = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            newSpawnerNPC.SpawnVillagers();
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            mSpawn = mSpawner.SpawnEnemy(mSniper);

            mSpawn.name = "SniperClone_" + ++mIncrementorSniper;
            mSpawn.transform.Translate(Vector3.forward * mIncrementorSniper * 1.5f);
        }
    }

}
