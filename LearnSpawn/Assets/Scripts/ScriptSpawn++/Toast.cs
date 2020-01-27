using UnityEngine;
using UnityEditor;

public class Toast : MonoBehaviour, TownsPeople
{
    public void Declaration()
    {
        Debug.Log("I am crispy");
        //EditorUtility.DisplayDialog("Toast","I am crispy.", "Ok");
    }
}