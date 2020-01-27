
using UnityEngine;

public class ClientCh4 : MonoBehaviour
{
    public NPCSpawner mSpawnerNPC;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            mSpawnerNPC.SpawnVillagers();
        }
    }
}
