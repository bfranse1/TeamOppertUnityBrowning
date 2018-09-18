using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public Vector3 center;

	Vector3 v = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime * 30);
		transform.Rotate(Vector3.right * Time.deltaTime * 8, Space.World);
	}
}
