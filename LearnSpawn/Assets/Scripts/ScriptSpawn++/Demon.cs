using UnityEngine;
using UnityEditor;

public class Demon : MonoBehaviour, Enemies
{    public void Fight()
    {
        //EditorUtility.DisplayDialog("Demon","You have summoned me.", "Ok");
        Debug.Log("You have summoned me.");
    }
}