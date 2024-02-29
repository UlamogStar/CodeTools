using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;

    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }
   
   public void CreateInstanceFromList(Vector3DList obj)
   {
       foreach (var t in obj.vector3Dlist)
       {
         Instantiate(prefab, t.value, Quaternion.identity);
       }
   }

   public void CreateInstanceFromListCounting(Vector3DList obj)
   {
      Instantiate(prefab, obj.vector3Dlist[num].value, Quaternion.identity);
     num++;
     
    if (num == obj.vector3Dlist.Count)
     {
         num = 0;
     }
   }

    public void CreateInstancerRandomized(Vector3DList obj)
   {
      num = Random.Range(0, obj.vector3Dlist.Count - 1);
      Instantiate(prefab, obj.vector3Dlist[num].value, Quaternion.identity);
   }
    
}
