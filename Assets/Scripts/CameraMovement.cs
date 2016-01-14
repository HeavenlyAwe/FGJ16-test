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

        Vector3 forward = transform.forward.normalized;
        Vector3 offset = new Vector3(forward.x, 0f, forward.z) * cameraOffset.z;
        offset.y = cameraOffset.y;
        transform.position = ball.transform.position + offset;

        float mouseDx = Input.GetAxis("Mouse X");
        transform.RotateAround(ball.transform.position, Vector3.up, mouseDx);
    }
}
