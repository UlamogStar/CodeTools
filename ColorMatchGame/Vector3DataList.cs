using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Vector3DataList", menuName = "ScriptableObjects/Vector3DataList", order = 5)]

public class Vector3DList : ScriptableObject
{
    public List<Vector3Data> vector3Dlist;
}
