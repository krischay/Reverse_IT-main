using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;            // The target (car) to follow
    public float smoothSpeed = 0.125f;  // Speed at which the camera smooths its movement
    public Vector3 offset = new Vector3(0, 2, -6); // Offset to place the camera in front of the car

    void LateUpdate()
    {
        if (target == null)
            return;

        // Calculate the desired position in front of the car
        Vector3 desiredPosition = target.position - target.forward * offset.z + Vector3.up * offset.y;
        
        // Smooth the transition to the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Make the camera always look at the car (point towards the back of the car)
        transform.LookAt(target);
    }
}
