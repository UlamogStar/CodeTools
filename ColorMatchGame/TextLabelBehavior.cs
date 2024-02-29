using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

[RequireComponent(typeof(Text))]
[RequireComponent(typeof(TMPro.TextMeshProUGUI))] 

public class TextLabelBehavior : MonoBehaviour
{
    private Text label;
    private TMPro.TextMeshProUGUI tmpLabel; 
   
    public UnityEngine.Events.UnityEvent startEvent;
    private void Start()
    {
        label = GetComponent<Text>();
        tmpLabel = GetComponent<TMPro.TextMeshProUGUI>(); 
       
        startEvent.Invoke();
    }
   
    public void UpdateLabel(FloatData obj)
    {
       if (label != null)
       {
           label.text = obj.value.ToString(CultureInfo.InvariantCulture);
       }
       else
       {
           tmpLabel.text = obj.value.ToString(CultureInfo.InvariantCulture); 
       }
    }
    public void UpdateLabel(IntData obj)
    {
        if (label != null)
        {
            label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        }
        else
        {
            tmpLabel.text = obj.value.ToString(CultureInfo.InvariantCulture); 
        }
    }
}
