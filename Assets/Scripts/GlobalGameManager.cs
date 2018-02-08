using UnityEngine;

[CreateAssetMenu]
public class GlobalGameManager : ScriptableObject
{
    public void PrintInfo(string info)
    {
        Debug.Log(info);
    }
}
