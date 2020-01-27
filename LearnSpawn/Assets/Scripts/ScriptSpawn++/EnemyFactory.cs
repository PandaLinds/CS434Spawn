using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public Enemies GetEnemy(EnemyType type)
    {
        switch(type)
        {
            case EnemyType.Demon:

                Enemies demon = new Demon();
                return demon;
            case EnemyType.King:
                Enemies king = new King();
                return king;
            case EnemyType.Marshmellow:
                Enemies marshmellow = new Marshmellow();
                return marshmellow;
        }
        return null;
    }
}
