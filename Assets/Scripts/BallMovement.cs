using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	public float rotationSpeed = .1f;
	public float movementSpeed = 5f;
	public float jumpSpeed = 15f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		float direction = Input.GetAxis("Horizontal");
		float acceleration = Input.GetAxis("Vertical");
		float jumpAcceleration = Input.GetButton ("Jump") ? 1f : 0f;
		rigidbody.AddForce (new Vector3 (0, jumpSpeed * jumpAcceleration, movementSpeed * acceleration));
		transform.Rotate (Vector3.up, direction * rotationSpeed);
	}
}
