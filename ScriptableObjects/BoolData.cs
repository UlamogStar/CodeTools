using UnityEngine;
[CreateAssetMenu]

public class BoolData : ScriptableObject
{
    public bool value;  

    public void UpdateValue(bool num)
    {
        value = num;
    }
}
