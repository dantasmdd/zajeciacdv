using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Data")]
public class Data : ScriptableObject
{
    public int hp;
    public int damage;
    public string name;
}
