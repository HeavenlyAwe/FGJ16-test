using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{

    public float rotationSpeed = .1f;
    public float movementSpeed = 100f;
    public float jumpSpeed = 15f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        float accelerationZ = Input.GetAxis("Vertical");
        float accelerationX = Input.GetAxis("Horizontal");

        Vector3 direction = Camera.main.transform.TransformDirection(new Vector3(accelerationX, 0f, accelerationZ));
        rigidbody.AddForce(direction * movementSpeed);
    }
}
