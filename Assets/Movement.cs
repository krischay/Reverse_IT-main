using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 50f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveDirection = Input.GetAxis("Vertical");
        float turnDirection = Input.GetAxis("Horizontal");

        if (moveDirection != 0)
        {
            rb.velocity = transform.forward * moveDirection * speed;
            rb.angularVelocity = Vector3.up * turnDirection * turnSpeed;
        }
    }
}
