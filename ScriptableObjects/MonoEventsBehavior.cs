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

   private void OnEnable()
   {
      startEvent.Invoke();
   }

   private void OnDisable()
   {
      disableEvent.Invoke();
   }
   
   private void OnCollisionEnter(Collision other)
   {
      collisionEnterEvent.Invoke();
   }

   private void OnCollisionExit(Collision other)
   {
      collisionExitEvent.Invoke();
   }

   private void OnTriggerEnter(Collision other)
   {
      triggerEnterEvent.Invoke();
   }
   

}
