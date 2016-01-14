using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{

    public float rotationSpeed = .1f;
    public float movementSpeed = 100f;
    public float jumpSpeed = 15f;
    
    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        float accelerationZ = Input.GetAxis("Vertical");
        float accelerationX = Input.GetAxis("Horizontal");

        Vector3 direction = Camera.main.transform.TransformDirection(new Vector3(accelerationX, 0f, accelerationZ));
        direction.y = 0.0f;
        rigidbody.AddForce(direction * movementSpeed * Time.deltaTime);

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            Debug.Log("Touchdown");
            rigidbody.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
        }
        // controller.Move(Physics.gravity + rigidbody.velocity);
    }
}
