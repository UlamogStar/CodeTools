using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{   
    public UnityEvent startEvent, repeatCountEvent, startCountEvent, endCountEvent, repeatUntilFalseEvent;

    public IntData counterNum;
    public bool canRun = false;
    public float seconds = 3.0f;
   
    private WaitForSeconds wfsobj;
    private WaitForFixedUpdate wffuobj;

    public void Start()
    {
        
        wfsobj = new WaitForSeconds(seconds);
        wffuobj = new WaitForFixedUpdate();
        startEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }   

    IEnumerator Counting()
    {   

       

        yield return wfsobj;

        startCountEvent.Invoke();
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsobj;
        }
        endCountEvent.Invoke();
       
    }
    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse()); 
    }
    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsobj;
            repeatUntilFalseEvent.Invoke();
        }
    }

    public bool CanRun
    {
        get => canRun;
        set => canRun = value;
    }

}
