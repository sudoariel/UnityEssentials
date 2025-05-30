using UnityEngine;

// Controls player movement and rotation
public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Speed of the player movement
    public float rotationSpeed = 120.0f; // Speed of the player rotation
    public float jumpForce = 5.0f; // Force applied when the player jumps (not used in this script but can be added later)
    private Rigidbody rb; // Reference to the player's Rigidbody component

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to the player
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange); // Apply an upward force when the jump button is pressed
        }
    }

    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical"); // Get vertical input (W/S or Up/Down arrows)
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime; // Calculate movement vector based on input and speed
        rb.MovePosition(rb.position + movement); // Move the player in the direction of the movement vector

        float moveHorizontal = Input.GetAxis("Horizontal"); // Get horizontal input (A/D or Left/Right arrows)
        Quaternion turn = Quaternion.Euler(0.0f, moveHorizontal * rotationSpeed * Time.fixedDeltaTime, 0.0f); // Calculate rotation based on input and rotation speed
        rb.MoveRotation(rb.rotation * turn); // Apply the rotation to the player's Rigidbody
    }
}
