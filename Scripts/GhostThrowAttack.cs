using UnityEngine;

public class GhostThrowAttack : MonoBehaviour
{
    [Tooltip("Animator component to trigger attack animations.")]
    public Animator animator;

    [Tooltip("Array of throwable objects (prefabs).")]
    public GameObject[] throwableObjects;

    [Tooltip("The force applied to the thrown object.")]
    public float throwForce = 10f;

    [Tooltip("The player's transform to target.")]
    public Transform playerTransform;

    [Tooltip("The spawn position for the throwable objects.")]
    public Transform spawnPoint;

    public void PerformThrowAttack()
    {
        if (throwableObjects.Length == 0 || playerTransform == null || spawnPoint == null)
        {
            Debug.LogWarning("Missing references for GhostThrowAttack.");
            return;
        }

        // Play the attack animation
        if (animator != null)
        {
            animator.SetTrigger("Throw");
        }

        // Select a random object to throw
        GameObject selectedObject = throwableObjects[Random.Range(0, throwableObjects.Length)];

        // Instantiate the object at the spawn point
        GameObject thrownObject = Instantiate(selectedObject, spawnPoint.position, Quaternion.identity);

        // Ensure the object has a Rigidbody component
        Rigidbody rb = thrownObject.GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = thrownObject.AddComponent<Rigidbody>(); // Add Rigidbody if it doesn't exist
        }

        // Calculate the direction to the player
        Vector3 direction = (playerTransform.position - spawnPoint.position).normalized;

        // Apply force to the object to throw it toward the player
        rb.linearVelocity = direction * throwForce; // Set velocity directly
    }

    public void PerformAttack()
    {
        PerformThrowAttack();
    }
}