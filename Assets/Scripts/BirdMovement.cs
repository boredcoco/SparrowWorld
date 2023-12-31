using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] private float xSpeed;
    [SerializeField] private float zSpeed;
    [SerializeField] private float keyboardSensitivity = 0.5f;
    [SerializeField] private float jumpSpeed = 1;

    [SerializeField] private Rigidbody rb;

    private Camera mainCamera;
    private Vector3 currentDirection;

    // code i copied off the internet
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    // horizontal rotation speed
    public float horizontalSpeed = 1f;
    // vertical rotation speed
    public float verticalSpeed = 1f;

    private void Start()
    {
      mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }

    private void FixedUpdate()
    {
        float xDirection = Input.GetAxis("Horizontal") * xSpeed * Time.deltaTime;
        float zDirection = Input.GetAxis("Vertical") * zSpeed * Time.deltaTime;
        Vector3 newForce = transform.rotation * new Vector3(xDirection, 0f, zDirection);

        if (Input.GetAxisRaw("Horizontal") != 0f || Input.GetAxisRaw("Vertical") != 0f)
        {
          currentDirection = rb.rotation * new Vector3(
            Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")
          );
        }

        rb.AddForce(newForce, ForceMode.VelocityChange);

        Quaternion targetRotation = Quaternion.LookRotation(currentDirection);
        Quaternion rotation = Quaternion.Slerp(rb.rotation, targetRotation, keyboardSensitivity * Time.deltaTime);
        rb.MoveRotation(rotation);

        if (!Input.GetMouseButtonDown(0)) {
          return;
        }
    }

    private void Update()
    {
      if (Input.GetKeyDown("space"))
      {
          Vector3 jumpForce = transform.up * jumpSpeed;
          rb.AddForce(jumpForce, ForceMode.VelocityChange);
      }
    }

}
