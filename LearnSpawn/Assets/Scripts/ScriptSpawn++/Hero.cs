using UnityEngine;
using UnityEditor;

public class Hero : MonoBehaviour, TownsPeople
{
    public void Declaration()
    {
        //EditorUtility.DisplayDialog("Hero","I shall protect you!", "Ok");
        Debug.Log("I will protect you");
    }
}