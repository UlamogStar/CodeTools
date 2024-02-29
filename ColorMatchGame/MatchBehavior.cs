using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
   public ID idObj;
   public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;

   private void OnTriggerEnter(Collider other)
   {  
       var tempOBJ = other.GetComponent<IDContainerBehavior>();
         if (tempOBJ == null) 
              return; 

         var otherID = tempOBJ.idObj;
         if(otherID == idObj)
            {
                Debug.Log("Match");
                matchEvent.Invoke();
            }
            else
            {
                Debug.Log("No Match");
                noMatchDelayedEvent.Invoke();
            }
   }
}