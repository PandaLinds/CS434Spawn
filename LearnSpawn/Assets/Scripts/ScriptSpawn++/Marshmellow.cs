using UnityEngine;
using UnityEditor;

public class Marshmellow : MonoBehaviour, Enemies
{
    public void Fight()
    {
        //EditorUtility.DisplayDialog("Marshmellow","I'm squishy.", "Ok");
        Debug.Log("I'm squishy.");
    }
}