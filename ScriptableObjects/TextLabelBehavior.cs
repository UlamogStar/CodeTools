using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

[RequireComponent(typeof(Text))]
[RequireComponent(typeof(TextMeshProUGUI))] 

public class TextLabelBehavior : MonoBehaviour
{
    public Text label;
    public TextMeshProUGUI tmpLabel; 
    public FloatData dataObj;
    public BoolData boolData;
    public IntData intData;

    private void Start()
    {
        label = GetComponent<Text>();
        tmpLabel = GetComponent<TextMeshProUGUI>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        if (label != null)
        {
            label.text = dataObj.value.ToString();
        }

        if (tmpLabel != null)
        {
            tmpLabel.text = dataObj.value.ToString();
        }
    }
}

