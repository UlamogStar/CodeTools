using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "GameAction", fileName = "NewGameAction")]
public class GameAction : ScriptableObject
{
    [Tooltip("Actions to perform when this GameAction is invoked.")]
    public UnityEvent onRun;

    // This method is called to invoke the action
    public void Invoke()
    {
        Debug.Log($"GameAction '{name}' invoked.");
        onRun?.Invoke(); // Trigger all actions in the UnityEvent
    }
}