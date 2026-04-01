using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class HelloKittyMovement : MonoBehaviour
{
    public float moveSpeed = 10000f;
    public float jumpForce = 7f;
    public Transform cameraTransform;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        if (cameraTransform == null && Camera.main != null)
        {
            cameraTransform = Camera.main.transform;
        }
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isGrounded)
        {
            rb.linearVelocity = new Vector3(
                rb.linearVelocity.x,
                jumpForce,
                rb.linearVelocity.z
            );
        }
    }

    void FixedUpdate()
    {
        Vector3 move = Vector3.zero;
        
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)move -= transform.forward;
        
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)move += transform.forward;
        
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)move += (-transform.forward + transform.right);
        
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)move += (-transform.forward - transform.right);
        
        move = move.normalized;
        
        rb.linearVelocity = new Vector3(
            
            move.x * moveSpeed,
            rb.linearVelocity.y,
            move.z * moveSpeed
        );
        
        if (move != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(-move);
            transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            5f * Time.fixedDeltaTime
            );
        }
    }

    void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}