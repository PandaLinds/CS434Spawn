using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory mFactory;

    private INPC mFarmer;
    private INPC mBeggar;
    private INPC mShopowner;

    public void SpawnVillagers()
    {
        //HAVE FACTORY MANUFACTURE THEM!!!

        mBeggar = mFactory.GetNPC(NPCType.Beggar);
        mFarmer = mFactory.GetNPC(NPCType.Farmer);
        mShopowner = mFactory.GetNPC(NPCType.Shopowner);

        mBeggar.Speak();
        mFarmer.Speak();
        mShopowner.Speak();
    }
}
