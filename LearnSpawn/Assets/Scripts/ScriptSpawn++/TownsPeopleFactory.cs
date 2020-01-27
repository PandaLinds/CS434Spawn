using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownsPeopleFactory : MonoBehaviour
{
    //Function to create new Enemes
    public TownsPeople GetTownsPeople(TownsPeopleType type)
    {
        switch(type)
        {
            case TownsPeopleType.Hero:
                TownsPeople hero = new Hero();
                return hero;
            case TownsPeopleType.Jerk:
                TownsPeople jerk = new Jerk();
                return jerk;
            case TownsPeopleType.Toast:
                TownsPeople toast = new Toast();
                return toast;
        }
        return null;
    }
}
