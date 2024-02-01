using UnityEngine;

[CreateAssetMenu(fileName = "Vector3Data", menuName = "ScriptableObjects/Vector3Data", order = 1)]
public class Vector3Data : ScriptableObject
{
    public Vector3 vector3Value;

    public void UpdateValue(Vector3 vector3Obj)
    {
        vector3Value = vector3Obj;
    }
    
    public void TransformValue(Transform transformObj)
    {
        vector3Value = transformObj.position;
    }
}
