using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{

    public float rotationSpeed = .1f;
    public float movementSpeed = 100f;
    public float jumpSpeed = 20f;

    private float distToGround = 0.0f;
    public float distToGroundOffset = 0.1f;

    void Start()
    {
        distToGround = GetComponent<SphereCollider>().bounds.extents.y + distToGroundOffset;
    }

    // Update is called once per frame
    void Update()
	{
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		
		float torqueX = Input.GetAxis("Vertical");
		float torqueY = 0f;
		float torqueZ = -Input.GetAxis("Horizontal");
		
		Vector3 torque = new Vector3(torqueX, torqueY, torqueZ);
		
		torque = Camera.main.transform.TransformDirection(torque);
		rigidbody.AddTorque(torque * movementSpeed * Time.deltaTime);

        if (isGrounded())
        {

            // TODO: Change the jump impulse to a more reliable way of jumping.
            if (Input.GetButton("Jump"))
            {
                rigidbody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            }
        }
    }

    private bool isGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround);
    }
}
