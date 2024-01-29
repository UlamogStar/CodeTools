using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class MonoEventsBehavior : MonoBehaviour
{
   public UnityEvent startEvent, awakeEvent, disableEvent;
   
   private void Awake()
   {
      awakeEvent.Invoke();
   }

   private void Start()
   {
      startEvent.Invoke();
   }

   private void OnDisable()
   {
      disableEvent.Invoke();
   }
    
}
