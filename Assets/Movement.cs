using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 10f;          // Speed of the car
    public float turnSpeed = 50f;      // Turning speed of the car
    private void Update()
    {
        // Get input for movement
        float moveDirection = Input.GetAxis("Vertical");   // W/S or Up/Down arrow keys
        float turnDirection = Input.GetAxis("Horizontal"); // A/D or Left/Right arrow keys

        // Move the car forward/backward
        if (moveDirection != 0)
        {
            // Only move and turn when there is forward or backward movement
            transform.Translate(Vector3.forward * moveDirection * speed * Time.deltaTime);

            // Turn the car left/right
            transform.Rotate(Vector3.up, turnDirection * turnSpeed * Time.deltaTime);
        }
    }
}

