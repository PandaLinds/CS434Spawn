using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClient : MonoBehaviour
{
    public NewEnemySpawner mSpawnerEnemy;
    public TownsPeopleSpawner mSpawnerTownsPeople;
    int peopleCnt = 0, enemyCnt = 0;
    
    public EnemyType GetEnemyReq ()
    {
        enemyCnt++;
        if((peopleCnt % 3) == 0)
        {
            return EnemyType.King;
        } 
        else if((peopleCnt % 3) == 1)
        {
            return EnemyType.Demon;
        } 
        else
        {
            return EnemyType.Marshmellow;
        }
    }

    public TownsPeopleType GetPeopleReq ()
    {
        peopleCnt++;
        if((enemyCnt % 3) == 0)
        {
            return TownsPeopleType.Hero;
        } 
        else if((peopleCnt % 3) == 1)
        {
            return TownsPeopleType.Jerk;
        } 
        else
        {
            return TownsPeopleType.Toast;
        }
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Trying to spawn Enemy");
            mSpawnerEnemy.SpawnEnemies(GetEnemyReq());
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Trying to spawn People");
            mSpawnerTownsPeople.SpawnTownsPeople(GetPeopleReq());
        }
    }
}
