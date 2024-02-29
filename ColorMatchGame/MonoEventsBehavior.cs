using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class MonoEventsBehavior : MonoBehaviour
{
   public UnityEvent startEvent, awakeEvent, disableEvent, enableEvent;
   
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
      enableEvent.Invoke();
   }

   private void OnDisable()
   {
      disableEvent.Invoke();
   }

   
   private void getComponent<T>()
   {
      GetComponent<T>();
   }

}
