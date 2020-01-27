using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Requirements
{
    int peopleCnt = 0, enemyCnt = 0, jerkCnt = 0, demonCnt = 0, marshCnt = 0, toastCnt = 0, kingCnt = 0, heroCnt;
    
    public EnemyType GetEnemyReq ()
    {
        enemyCnt++;
        if((peopleCnt % 20) == 0)
        {
            kingCnt++;
            return EnemyType.King;
        } 

        if((jerkCnt % 5) == 0)
        {
            demonCnt++;
            return EnemyType.Demon;
        }

        if((heroCnt % 10) == 0)
        {
            marshCnt++;
            return EnemyType.Marshmellow;
        }

        marshCnt++;
        return EnemyType.Marshmellow;
    }

    public TownsPeopleType GetPeopleReq ()
    {
        peopleCnt++;
        if((enemyCnt % 10) == 0)
        {
            heroCnt++;
            return TownsPeopleType.Hero;
        }

        if((demonCnt % 3) == 0)
        {
            jerkCnt++;
            return TownsPeopleType.Jerk;
        }

        if((kingCnt % 15) == 0)
        {
            toastCnt++;
            return TownsPeopleType.Toast;
        }

        toastCnt++;
        return TownsPeopleType.Toast;
    }
}
