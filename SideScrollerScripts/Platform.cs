using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 movementDirection = Vector3.right; // Set the movement direction in the Inspector
    public float speed = 1f;
    //public int Color;
    private Vector3 originalPosition;
    private Vector3 targetPosition;

    private void Start()
    {
        originalPosition = transform.position;
        targetPosition = originalPosition + movementDirection;
       // GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //var cubeRenderer = cube.GetComponent<Renderer>();
        //cubeRenderer.material.SetColor("Red", Color.Red);
    }

    private void Update()
    {
        // Calculate the new position based on movement direction, speed, and time
        Vector3 newPosition = Vector3.Lerp(originalPosition, targetPosition, Mathf.PingPong(Time.time * speed, 1));

        // Update the platform's position
        transform.position = newPosition;
    }
}