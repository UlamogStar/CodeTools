using UnityEngine;
using System.Collections;
using UnityEngine.Events;


public class DraggableBehavior : MonoBehaviour
{
   private Camera cameraObj;
   public bool draggable;
   public UnityEvent OnDragStart, OnDragEnd;

    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        while (Input.GetMouseButton(0))
        {
            OnDragStart.Invoke();
            draggable = true;

            while (draggable)
            {
                Vector3 mousePos = cameraObj.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
                yield return new WaitForFixedUpdate();
            }
        }
    }

    private void OnMouseUp()
    {   
        OnDragEnd.Invoke(); 
        draggable = false;
    }

}
