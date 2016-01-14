using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public GameObject ball;
	public Vector3 cameraOffset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rigidBody = ball.GetComponent<Rigidbody> ();
		Vector3 velocity = rigidBody.velocity;
		velocity.y = 0;
		Vector3 offset = new Vector3 ();
		offset = velocity.normalized * cameraOffset.z;
		offset.y = cameraOffset.y;
		transform.position = ball.transform.position + offset;

		transform.rotation = Quaternion.Euler (new Vector3(30, Vector3.Angle (Vector3.forward, velocity), 0));
	}
}
