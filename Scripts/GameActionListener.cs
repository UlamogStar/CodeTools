using UnityEngine;

public class GameActionListener : MonoBehaviour
{
    [Tooltip("The GameAction to listen for.")]
    public GameAction gameAction;

    [Tooltip("The target object with the script to invoke.")]
    public MonoBehaviour targetScript;

    [Tooltip("The name of the method to invoke on the target script.")]
    public string methodName;

    private void OnEnable()
    {
        if (gameAction != null)
        {
            gameAction.onRun.AddListener(InvokeTargetMethod);
        }
    }

    private void OnDisable()
    {
        if (gameAction != null)
        {
            gameAction.onRun.RemoveListener(InvokeTargetMethod);
        }
    }

    private void InvokeTargetMethod()
    {
        if (targetScript != null && !string.IsNullOrEmpty(methodName))
        {
            var method = targetScript.GetType().GetMethod(methodName);
            if (method != null)
            {
                method.Invoke(targetScript, null);
            }
            else
            {
                Debug.LogWarning($"Method '{methodName}' not found on script '{targetScript.GetType().Name}'.");
            }
        }
        else
        {
            Debug.LogWarning("Target script or method name is not set.");
        }
    }
}