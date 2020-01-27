using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//how to implement abstract factory
public abstract class AbstractFactory
{
    public abstract TownsPeople iEnemyFactory();
    public abstract Enemies iTownsPeopleFactory();
}
