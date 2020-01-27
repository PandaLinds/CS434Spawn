using UnityEngine;

public class TownsPeopleSpawner : MonoBehaviour
{
    public TownsPeopleFactory mFactory;

    public void SpawnTownsPeople(TownsPeopleType peopleToSpawn)
    {
        //HAVE FACTORY MANUFACTURE THEM!!!

        TownsPeople mPerson = mFactory.GetTownsPeople(peopleToSpawn);

        mPerson.Declaration();
    }
}