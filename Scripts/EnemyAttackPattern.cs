using System.Collections;
using UnityEngine;

public class EnemyAttackPattern : MonoBehaviour
{
    [System.Serializable]
    public class AttackPattern
    {
        [Tooltip("Name of the attack (for identification purposes).")]
        public string attackName;

        [Tooltip("Time (in seconds) to wait before starting this attack.")]
        public float delayBeforeAttack;

        [Tooltip("Duration (in seconds) for which this attack will last.")]
        public float attackDuration;

        [Tooltip("GameAction to invoke for this attack.")]
        public GameAction attackAction;
    }

    [Tooltip("List of attack patterns the enemy will execute.")]
    public AttackPattern[] attackPatterns;

    [Tooltip("Should the attack patterns loop indefinitely?")]
    public bool loopPatterns = true;

    private int currentPatternIndex = 0;
    private bool isAttacking = false;

    private void Start()
    {
        StartCoroutine(ExecuteAttackPatterns());
    }

    private IEnumerator ExecuteAttackPatterns()
    {
        while (true)
        {
            if (currentPatternIndex >= attackPatterns.Length)
            {
                if (loopPatterns)
                {
                    currentPatternIndex = 0; // Reset to the first pattern
                }
                else
                {
                    yield break; // Stop if not looping
                }
            }

            AttackPattern currentPattern = attackPatterns[currentPatternIndex];

            // Wait before starting the attack
            yield return new WaitForSeconds(currentPattern.delayBeforeAttack);

            // Execute the attack
            isAttacking = true;
            Debug.Log($"Executing attack: {currentPattern.attackName}");

            if (currentPattern.attackAction != null)
            {
                currentPattern.attackAction.Invoke();
            }

            yield return new WaitForSeconds(currentPattern.attackDuration);

            isAttacking = false;
            Debug.Log($"Finished attack: {currentPattern.attackName}");

            // Move to the next pattern
            currentPatternIndex++;
        }
    }
}