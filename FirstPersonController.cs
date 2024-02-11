using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public float speed = 5.0f;
    public float sensitivity = 2.0f;
    private CharacterController character;

    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Get input from the controller
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        // Calculate movement and rotation
        Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical;
        move = move * speed * Time.deltaTime;
        
        character.Move(move);

        // Camera rotation (or player if the camera is a child of the player GameObject)
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");

        Vector3 rotation = new Vector3(0, rotateHorizontal, 0) * sensitivity;
        transform.Rotate(rotation);
        
        // Optional: Add vertical rotation for the camera
    }
}
