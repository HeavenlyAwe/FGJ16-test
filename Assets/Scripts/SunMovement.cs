using UnityEngine;
using System.Collections;

public class SunMovement : MonoBehaviour {

    public float speed = 10f;
    
    // Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
	}
}
