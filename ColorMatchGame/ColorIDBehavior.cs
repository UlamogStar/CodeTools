using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
   public ColorIDDataList colorIDDataListObj;

   private void Awake()
   {
        idObj = colorIDDataListObj.currentColor;
   }
}
